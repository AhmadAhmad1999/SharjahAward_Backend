﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;

namespace SharijhaAward.Application.Features.Categories.Queries.GetCategoryById
{
    public class GetCategoryByIdQueryHandler 
        : IRequestHandler<GetCategoryByIdQuery , BaseResponse<CategoryDto>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        private readonly IAsyncRepository<ExplanatoryGuide> _explanatoryGuideRepository;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;

        public GetCategoryByIdQueryHandler(IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IAsyncRepository<ExplanatoryGuide> explanatoryGuideRepository,
            IMapper mapper,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository)
        {
            _categoryRepository = categoryRepository;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _explanatoryGuideRepository = explanatoryGuideRepository;
            _mapper = mapper;
            _EducationalEntityRepository = EducationalEntityRepository;
        }

        public async Task<BaseResponse<CategoryDto>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == request.Id);

            if (category == null)
            {
                string msg = request.lang == "en"
                    ? "Category Not Found"
                    : "الفئة غير موجودة";

                return new BaseResponse<CategoryDto>(msg, false, 404);
            }
            
            var data = _mapper.Map<CategoryDto>(category);

            var Guide = await _explanatoryGuideRepository.FirstOrDefaultAsync(g => g.CategoryId == category.Id);
            var mainCategory = await _categoryRepository.IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == category.ParentId)!;

            data.isHasFile = Guide == null ? false : true; 
            data.Name = request.lang == "ar" ? category.ArabicName : category.EnglishName;
            data.Description = request.lang == "ar" ? category.ArabicDescription : category.EnglishDescription;
          
            if (mainCategory != null)
            {
                data.MainCategoryName = request.lang == "ar" ? mainCategory!.ArabicName : mainCategory!.EnglishName;
            }

            if (data.RelatedToClasses != null
                ? data.RelatedToClasses.Value
                : false)
            {
                data.EducationalClasses = await _CategoryEducationalClassRepository
                    .Where(x => x.CategoryId == request.Id)
                    .Select(x => new CategoryEducationalClassesDto()
                    {
                        Id = x.EducationalClassId,
                        Name = request.lang == "en"
                            ? x.EducationalClass!.EnglishName
                            : x.EducationalClass!.ArabicName,
                        NumberOfExpectedWinners = x.NumberOfExpectedWinners
                    }).ToListAsync();
            }
            if (data.RelatedToEducationalEntities)
            {
                data.EducationalEntityIds = await _EducationalEntityRepository
                    .Select(x => new CategoryEducationalEntitiesDto()
                    {
                        Id = x.Id,
                        Name = request.lang == "en"
                            ? x.EnglishName
                            : x.ArabicName
                    }).ToListAsync();
            }

            if (category.ParentId == null)
            {
                data.SubCategories = await _categoryRepository
                    .Where(x => x.ParentId == category.Id)
                    .Select(x => new SubCategoriesDto()
                    {
                        Id = x.Id,
                        Name = request.lang == "en"
                            ? x.EnglishName
                            : x.ArabicName,
                        Description = request.lang == "en"
                            ? x.EnglishDescription
                            : x.ArabicDescription,
                        ArbitrationAuditEndDate = x.ArbitrationAuditEndDate,
                        ArbitrationAuditStartDate = x.ArbitrationAuditStartDate,
                        FinalArbitrationEndDate = x.FinalArbitrationEndDate,
                        FinalArbitrationStartDate = x.FinalArbitrationStartDate,
                        InitialArbitrationEndDate = x.InitialArbitrationEndDate,
                        InitialArbitrationStartDate = x.InitialArbitrationStartDate,
                        SortingFormsEndDate = x.SortingFormsEndDate,
                        SortingFormsStartDate = x.SortingFormsStartDate
                    }).ToListAsync();
            }

            return new BaseResponse<CategoryDto>("",true, 200, data);
        }
    }
}
