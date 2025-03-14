﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Categories.Queries.GetCategoriesWithSubcategories;
using SharijhaAward.Application.Features.Rewards.Queries.GetAllRewards;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using SharijhaAward.Domain.Entities.RewardModel;

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
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllCategoryQueryHandler(IAsyncRepository<ExplanatoryGuide> explanatoryGuideRepository,
            IAsyncRepository<Cycle> cycleRepository, 
            IAsyncRepository<Reward> rewardRepository, 
            IAsyncRepository<Category> categoryRepository, 
            IMapper mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            _categoryRepository = categoryRepository;
            _rewardRepository = rewardRepository;
            _cycleRepository = cycleRepository;
            _explanatoryGuideRepository = explanatoryGuideRepository;
            _mapper = mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
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

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

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

                    data[i].subcategories[j].Icon = data[i].subcategories[j].Icon.Contains("wwwroot")
                        ? (WWWRootFilePath + data[i].subcategories[j].Icon.Split("wwwroot")[1]).Replace("\\", "/")
                        : data[i].subcategories[j].Icon.Replace("\\", "/");
                }

                data[i].Name = request.lang == "ar" ? data[i].ArabicName : data[i].EnglishName;
                data[i].Description = request.lang == "ar" ? data[i].ArabicDescription : data[i].EnglishDescription;

                data[i].Icon = data[i].Icon.Contains("wwwroot")
                    ? (WWWRootFilePath + data[i].Icon.Split("wwwroot")[1]).Replace("\\", "/")
                    : data[i].Icon.Replace("\\", "/");
            }
           
            int count = _categoryRepository.Where(c=>c.CycleId == Cycle!.Id).Count();
           
            Pagination pagination = new Pagination(request.page,request.perPage,count);
           
            return new BaseResponse<List<CategoryListVM>>("", true, 200,data, pagination);
        }
    }
}
