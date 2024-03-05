using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GetCategoriesWithSubcategories
{
    public class GetCategoriesWithSubcategoriesQueryHandler
        : IRequestHandler<GetCategoriesWithSubcategoriesQuery, BaseResponse<List<CategoriesSubcategoriesDto>>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository; 
        private readonly IMapper _mapper;

        public GetCategoriesWithSubcategoriesQueryHandler(
            IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<Cycle> cycleRepository,
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<CategoriesSubcategoriesDto>>> Handle(GetCategoriesWithSubcategoriesQuery request, CancellationToken cancellationToken)
        {
            var CycleId = _cycleRepository.Where(c => c.isDeleted == false).OrderBy(c=>c.CreatedAt).Last().Id;
            var categories = _categoryRepository.Where(c => c.CycleId == CycleId).Where(c=>c.ParentId==null).ToList();
            var data = _mapper.Map<List<CategoriesSubcategoriesDto>>(categories);
            for (int i=0; i<data.Count; i++)
            {
                data[i].Name = request.lang == "en" ? categories[i].EnglishName : categories[i].ArabicName;
                List<Category> subCategories = _categoryRepository.Where(c => c.ParentId == data[i].Id).ToList();
                data[i].subcategories = _mapper.Map<List<SubcategoriesListVM>>(subCategories);
                for(int j=0; j < subCategories.Count; j++)
                {
                    data[i].subcategories![j].Name = request.lang == "en" ? subCategories[j].EnglishName : subCategories[j].ArabicName;
                }
              
            }
            return new BaseResponse<List<CategoriesSubcategoriesDto>>("",true,200,data);
        }
    }
}
