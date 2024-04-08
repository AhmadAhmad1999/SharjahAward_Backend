using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GetCategoryById
{
    public class GetCategoryByIdQueryHandler 
        : IRequestHandler<GetCategoryByIdQuery , BaseResponse<CategoryDto>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        private readonly IMapper _mapper;

        public GetCategoryByIdQueryHandler(IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
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

            if (data.RelatedToClasses)
            {
                data.EducationalClasses = await _CategoryEducationalClassRepository
                    .Where(x => x.CategoryId == request.Id)
                    .Include(x => x.EducationalClass!)
                    .Select(x => new CategoryEducationalClassesDto()
                    {
                        Id = x.EducationalClassId,
                        Name = request.lang == "en"
                            ? x.EducationalClass!.EnglishName
                            : x.EducationalClass!.ArabicName
                    }).ToListAsync();
            }

            return new BaseResponse<CategoryDto>("",true, 200, data);
        }
    }
}
