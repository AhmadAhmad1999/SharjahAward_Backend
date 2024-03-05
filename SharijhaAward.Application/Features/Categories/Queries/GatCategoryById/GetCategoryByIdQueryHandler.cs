using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GatCategoryById
{
    public class GetCategoryByIdQueryHandler 
        : IRequestHandler<GetCategoryByIdQuery , BaseResponse<CategoryDto>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryByIdQueryHandler(IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<CategoryDto>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id);

            if (category == null)
            {
                string msg = request.lang == "en"
                    ? "Category Not Found"
                    : "الفئة غير موجودة";

                return new BaseResponse<CategoryDto>(msg, false, 404);
            }

            var data = _mapper.Map<CategoryDto>(category);
            var mainCategory = await _categoryRepository.GetByIdAsync(category.ParentId)!;

            data.Name = request.lang == "ar" ? category.ArabicName : category.EnglishName;
            data.Description = request.lang == "ar" ? category.ArabicDescription : category.EnglishDescription;
            if (mainCategory != null)
            {
                data.MainCategoryName = request.lang == "ar" ? mainCategory!.ArabicName : mainCategory!.EnglishName;
            }

            return new BaseResponse<CategoryDto>("",true, 200, data);
        }
    }
}
