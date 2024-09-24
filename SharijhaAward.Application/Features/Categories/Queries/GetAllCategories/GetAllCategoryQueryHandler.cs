using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Categories.Queries.GetCategoriesWithSubcategories;
using SharijhaAward.Application.Features.Rewards.Queries.GetAllRewards;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using SharijhaAward.Domain.Entities.RewardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoryQueryHandler
        : IRequestHandler<GetAllCategoryQuery, BaseResponse<List<CategoryListVM>>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<Reward> _rewardRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<ExplanatoryGuide> _explanatoryGuideRepository;
        private readonly IMapper _mapper;

        public GetAllCategoryQueryHandler(IAsyncRepository<ExplanatoryGuide> explanatoryGuideRepository, IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<Reward> rewardRepository, IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _rewardRepository = rewardRepository;
            _cycleRepository = cycleRepository;
            _explanatoryGuideRepository = explanatoryGuideRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<CategoryListVM>>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            var Cycle =  request.CycleId == null
                ? await _cycleRepository.FirstOrDefaultAsync(c => c.Status == Domain.Constants.Common.Status.Active)
                : await _cycleRepository.GetByIdAsync(request.CycleId);
            
                var categories = await _categoryRepository
                    .Where(c => c.CycleId == Cycle!.Id && c.ParentId == null)
                    .OrderByDescending(x => x.CreatedAt)
                    .ToListAsync();
            
          
            var data = _mapper.Map<List<CategoryListVM>>(categories);

            var rewards = await _rewardRepository.ListAllAsync();
            
            var Rewards = _mapper.Map<List<RewardListVm>>(rewards);
           
            for (int i = 0; i < data.Count; i++)
            {
                List<Category> subCategories = _categoryRepository
                    .Where(c => c.ParentId == data[i].Id)
                    .Include(x => x.Parent!)
                    .ToList();
               
                data[i].subcategories = _mapper.Map<List<SubcategoriesListVM>>(subCategories);
                for(int j = 0; j < data[i].subcategories.Count(); j++)
                {
                    var expGiud = await _explanatoryGuideRepository.FirstOrDefaultAsync(e=>e.CategoryId == data[i].Id);
                    
                    if(expGiud != null)
                    {
                        data[i].ExplanatoryGuideUrl = request.lang == "en"
                            ? expGiud.EnglishFilePath
                            : expGiud.ArabicFilePath;
                    }
                   
                    data[i].subcategories[j].Name = request.lang == "en"
                        ? subCategories[j].EnglishName
                        : subCategories[j].ArabicName;   

                    data[i].subcategories[j].Description = request.lang == "en"
                        ? subCategories[j].EnglishDescription
                        : subCategories[j].ArabicDescription;

                    data[i].subcategories[j].Rewards = Rewards.Where(r => r.CategoryId == subCategories[j].Id).ToList();
                }

                data[i].Name = request.lang == "ar" ? data[i].ArabicName : data[i].EnglishName;
                data[i].Description = request.lang == "ar" ? data[i].ArabicDescription : data[i].EnglishDescription;
            }
           
            int count = _categoryRepository.GetCount(c=>c.isDeleted == false);
           
            Pagination pagination = new Pagination(request.page,request.perPage,count);
           
            return new BaseResponse<List<CategoryListVM>>("", true, 200,data, pagination);
        }
    }
}
