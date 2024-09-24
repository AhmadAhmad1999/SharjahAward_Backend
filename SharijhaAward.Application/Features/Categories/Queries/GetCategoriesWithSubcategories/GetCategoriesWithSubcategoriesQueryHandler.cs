using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Classes.Queries.GetAllCategoryClassesByCategoryId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;

namespace SharijhaAward.Application.Features.Categories.Queries.GetCategoriesWithSubcategories
{
    public class GetCategoriesWithSubcategoriesQueryHandler
        : IRequestHandler<GetCategoriesWithSubcategoriesQuery, BaseResponse<List<CategoriesSubcategoriesDto>>>
    {
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;

        public GetCategoriesWithSubcategoriesQueryHandler(IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<Cycle> CycleRepository)
        {
            _CategoryRepository = CategoryRepository;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _EducationalEntityRepository = EducationalEntityRepository;
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

            List<Category> AllSubCategories = await _CategoryRepository
                .Where(x => x.ParentId != null
                    ? (MainCategories.Select(y => y.Id).Any(y => y == x.ParentId))
                    : false)
                .Include(x => x.Parent!)
                .ToListAsync();

            List<CategoryEducationalClass> AllCategoryEducationalClasses = await _CategoryEducationalClassRepository
                .Where(x => AllSubCategories.Select(y => y.Id).Contains(x.CategoryId))
                .ToListAsync();

            List<GetAllCategoryEducationalEntitiesByCategoryIdDto> AllCategoryEducationalEntities = await _EducationalEntityRepository
                .Select(x => new GetAllCategoryEducationalEntitiesByCategoryIdDto()
                {
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishName 
                        : x.ArabicName,
                }).ToListAsync();

            foreach (CategoriesSubcategoriesDto MainCategory in MainCategories)
            {
                MainCategory.subcategories = AllSubCategories
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
                        RelatedToClasses = x.RelatedToClasses,
                        SubCategoryClasses = (x.RelatedToClasses != null
                            ? x.RelatedToClasses.Value 
                                ? AllCategoryEducationalClasses
                                    .Where(y => y.CategoryId == x.Id)
                                    .Select(y => new GetAllCategoryClassesByCategoryIdDto()
                                    {
                                        Id = y.Id,
                                        Name = Request.lang == "en"
                                            ? y.EducationalClass!.EnglishName
                                            : y.EducationalClass!.ArabicName
                                    }).ToList()
                                : new List<GetAllCategoryClassesByCategoryIdDto>()
                            : new List<GetAllCategoryClassesByCategoryIdDto>()),
                        RelatedToEducationalEntities = x.RelatedToEducationalEntities,
                        SubCategoryEducationalEntities = x.RelatedToEducationalEntities 
                            ? AllCategoryEducationalEntities
                            : new List<GetAllCategoryEducationalEntitiesByCategoryIdDto>()
                    }).ToList();
            }

            return new BaseResponse<List<CategoriesSubcategoriesDto>>(ResponseMessage, true, 200, MainCategories);
        }
    }
}
