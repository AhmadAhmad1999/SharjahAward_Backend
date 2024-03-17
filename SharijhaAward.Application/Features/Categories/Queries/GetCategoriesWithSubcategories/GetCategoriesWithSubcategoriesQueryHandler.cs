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
            
            var CycleId = request.CycleId != Guid.Empty 
                ? request.CycleId
                : _cycleRepository.FirstOrDefault(c => c.Status == Domain.Constants.Common.Status.Active)!.Id;
                 
           
            var categories = _categoryRepository.Where(c => c.CycleId == CycleId).Where(c=>c.ParentId==null).ToList();
           
            var data = _mapper.Map<List<CategoriesSubcategoriesDto>>(categories);
           
            bool isHttps = _httpContextAccessor.HttpContext.Request.IsHttps;
           
            for (int i=0; i<data.Count; i++)
            {
                data[i].Icon = isHttps
                            ? $"https://{_httpContextAccessor.HttpContext?.Request.Host.Value}/UploadedFiles/{categories[i].Icon.Split('\\').LastOrDefault()}"
                            : $"http://{_httpContextAccessor.HttpContext?.Request.Host.Value}/UploadedFiles/{categories[i].Icon.Split('\\').LastOrDefault()}";
               
                data[i].Name = request.lang == "en" ? categories[i].EnglishName : categories[i].ArabicName;
               
                List<Category> subCategories = _categoryRepository.Where(c => c.ParentId == data[i].Id).ToList();
               
                data[i].subcategories = _mapper.Map<List<SubcategoriesListVM>>(subCategories);
                
                for(int j=0; j < subCategories.Count; j++)
                {
                    data[i].subcategories![j].Icon = isHttps
                            ? $"https://{_httpContextAccessor.HttpContext?.Request.Host.Value}/UploadedFiles/{categories[i].Icon.Split('\\').LastOrDefault()}"
                            : $"http://{_httpContextAccessor.HttpContext?.Request.Host.Value}/UploadedFiles/{categories[i].Icon.Split('\\').LastOrDefault()}";

                    data[i].subcategories![j].Name = request.lang == "en" ? subCategories[j].EnglishName : subCategories[j].ArabicName;
                }
              
            }
            return new BaseResponse<List<CategoriesSubcategoriesDto>>("",true,200,data);
        }
    }
}
