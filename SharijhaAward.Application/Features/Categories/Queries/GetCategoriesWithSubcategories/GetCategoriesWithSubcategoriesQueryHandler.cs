using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Classes.Queries.GetAllCategoryClassesByCategoryId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;

namespace SharijhaAward.Application.Features.Categories.Queries.GetCategoriesWithSubcategories
{
    public class GetCategoriesWithSubcategoriesQueryHandler
        : IRequestHandler<GetCategoriesWithSubcategoriesQuery, BaseResponse<List<CategoriesSubcategoriesDto>>>
    {
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;

        public GetCategoriesWithSubcategoriesQueryHandler(IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IAsyncRepository<Cycle> CycleRepository)
        {
            _CategoryRepository = CategoryRepository;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _CycleRepository = CycleRepository;
        }

        public async Task<BaseResponse<List<CategoriesSubcategoriesDto>>> Handle(GetCategoriesWithSubcategoriesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Cycle? CycleEntity = Request.CycleId != null
                ? await _CycleRepository.GetByIdAsync(Request.CycleId)
                : await _CycleRepository.FirstOrDefaultAsync(c => c.Status == Domain.Constants.Common.Status.Active);
                 
            if(CycleEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "There is no active cycle yet"
                    : "لا يوجد دورات للمشاركة";

                return new BaseResponse<List<CategoriesSubcategoriesDto>>(ResponseMessage, false, 404);
            }
         
            List<CategoriesSubcategoriesDto> MainCategories = await _CategoryRepository
                .Where(x => x.CycleId == CycleEntity.Id && x.ParentId == null &&
                    ((CycleEntity.GroupCategoryNumber != 0 
                        ? x.CategoryClassification == Domain.Constants.CategoryConstants.CategoryClassification.Group
                        : false) ||
                    (CycleEntity.IndividualCategoryNumber != 0
                        ? x.CategoryClassification == Domain.Constants.CategoryConstants.CategoryClassification.Individual
                        : false)))
                .Select(x => new CategoriesSubcategoriesDto()
                {
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishName
                        : x.ArabicName,
                    Icon = x.Icon
                }).ToListAsync();

            foreach (CategoriesSubcategoriesDto MainCategory in MainCategories)
            {
                MainCategory.subcategories = await _CategoryRepository
                    .Where(x => x.ParentId != null 
                        ? (x.ParentId == MainCategory.Id ) 
                        : false)
                    .Select(x => new SubcategoriesListVM()
                    {
                        Id = x.Id,
                        Name = Request.lang == "en"
                            ? x.EnglishName
                            : x.ArabicName,
                        Icon = x.Icon,
                        RelatedToClasses = x.RelatedToClasses
                    }).ToListAsync();

                foreach (SubcategoriesListVM SubCategory in MainCategory.subcategories
                    .Where(x => x.RelatedToClasses != null 
                        ? x.RelatedToClasses.Value 
                        : false))
                {
                    SubCategory.SubCategoryClasses = await _CategoryEducationalClassRepository
                        .Where(x => x.CategoryId == SubCategory.Id)
                        .Include(x => x.EducationalClass!)
                        .Select(x => new GetAllCategoryClassesByCategoryIdDto()
                        {
                            Id = x.Id,
                            Name = Request.lang == "en"
                                ? x.EducationalClass!.EnglishName
                                : x.EducationalClass!.ArabicName
                        }).ToListAsync();
                }
            }

            return new BaseResponse<List<CategoriesSubcategoriesDto>>(ResponseMessage, true, 200, MainCategories);
        }
    }
}
