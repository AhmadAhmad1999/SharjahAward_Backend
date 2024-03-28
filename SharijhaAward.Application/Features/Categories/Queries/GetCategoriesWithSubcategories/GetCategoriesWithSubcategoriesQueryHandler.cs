using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
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
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public GetCategoriesWithSubcategoriesQueryHandler(
            IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<Cycle> cycleRepository,
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _cycleRepository = cycleRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<CategoriesSubcategoriesDto>>> Handle(GetCategoriesWithSubcategoriesQuery request, CancellationToken cancellationToken)
        {
            
            var CycleId = request.CycleId != null
                ? request.CycleId
                : _cycleRepository.FirstOrDefault(c => c.Status == 0)!.Id;
                 
            if(CycleId == null)
            {
                string msg = request.lang == "en"
                    ? "There is no Active Cycle yet"
                    : "لا يوجد دورات للمشاركة";

                return new BaseResponse<List<CategoriesSubcategoriesDto>>(msg, false, 400);
            }
            var Cycle = await _cycleRepository.GetByIdAsync(CycleId);
         
            var categories = _categoryRepository.Where(c => c.CycleId == CycleId && c.Status == Domain.Constants.Common.Status.Active).Where(c=>c.ParentId==null).ToList();
            
            if (Cycle.GroupCategoryNumber == 0)
            {
                categories = _categoryRepository.Where(c => c.CycleId == CycleId && c.Status == Domain.Constants.Common.Status.Active).Where(c => c.ParentId == null && c.CategoryClassification != Domain.Constants.CategoryConstants.CategoryClassification.Group).ToList();
            }
            if(Cycle.IndividualCategoryNumber == 0)
            {
                categories = _categoryRepository.Where(c => c.CycleId == CycleId && c.Status == Domain.Constants.Common.Status.Active).Where(c => c.ParentId == null && c.CategoryClassification != Domain.Constants.CategoryConstants.CategoryClassification.Individual).ToList();
            }
           
            var data = _mapper.Map<List<CategoriesSubcategoriesDto>>(categories);
           
            for (int i=0; i<data.Count; i++)
            {
               
                data[i].Name = request.lang == "en" ? categories[i].EnglishName : categories[i].ArabicName;
               
                List<Category> subCategories = _categoryRepository.Where(c => c.ParentId == data[i].Id && c.Status != Domain.Constants.Common.Status.Close).ToList();
               
                if(Cycle.GroupCategoryNumber == 0)
                {
                    subCategories = _categoryRepository.Where(c => c.ParentId == data[i].Id && c.Status == Domain.Constants.Common.Status.Active && c.CategoryClassification != Domain.Constants.CategoryConstants.CategoryClassification.Group).ToList();
                }
                if(Cycle.IndividualCategoryNumber == 0)
                {
                    subCategories = _categoryRepository.Where(c => c.ParentId == data[i].Id && c.Status == Domain.Constants.Common.Status.Active && c.CategoryClassification != Domain.Constants.CategoryConstants.CategoryClassification.Individual).ToList();
                }

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
