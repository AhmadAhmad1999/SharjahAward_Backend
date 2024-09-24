using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllSubCategoriesWithClasses
{
    public class GetAllSubCategoriesWithClassesHandler 
        : IRequestHandler<GetAllSubCategoriesWithClassesQuery, BaseResponse<List<GetAllSubCategoriesWithClassesListVM>>>
    {
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        private readonly IMapper _Mapper;
        public GetAllSubCategoriesWithClassesHandler(IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IMapper Mapper)
        {
            _CategoryRepository = CategoryRepository;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllSubCategoriesWithClassesListVM>>> 
            Handle(GetAllSubCategoriesWithClassesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (!string.IsNullOrEmpty(Request.CategoryName))
            {
                List<Category> CategoriesEntities = new List<Category>();

                if (Request.lang == "en")
                {
                    CategoriesEntities = await _CategoryRepository
                        .IncludeThenWhere(x => x.Parent!, x => x.Cycle.Status == Domain.Constants.Common.Status.Active &&
                            x.ParentId != null &&
                            x.EnglishName.ToLower().StartsWith(Request.CategoryName.ToLower()))
                        .ToListAsync();
                }
                else
                {
                    CategoriesEntities = await _CategoryRepository
                        .IncludeThenWhere(x => x.Parent!, x => x.Cycle.Status == Domain.Constants.Common.Status.Active &&
                            x.ParentId != null &&
                            x.ArabicName.ToLower().StartsWith(Request.CategoryName.ToLower()))
                        .ToListAsync();
                }

                List<CategoryEducationalClass> CategoryEducationalClassEntities = await _CategoryEducationalClassRepository
                    .Where(x => CategoriesEntities.Select(y => y.Id).Contains(x.CategoryId))
                    .ToListAsync();

                List<GetAllSubCategoriesWithClassesListVM> Response = CategoriesEntities
                    .Select(x => new GetAllSubCategoriesWithClassesListVM()
                    {
                        Id = x.Id,
                        CategoryName = Request.lang == "en"
                            ? x.EnglishName
                            : x.ArabicName,
                        RelatedToClasses = x.RelatedToClasses,
                        Classes = CategoryEducationalClassEntities
                            .Where(y => y.CategoryId == x.Id)
                            .Select(y => new ClassesDto()
                            {
                                Id = y.Id,
                                ClassName = Request.lang == "en"
                                    ? y.EducationalClass!.EnglishName
                                    : y.EducationalClass!.ArabicName
                            }).ToList()
                    }).ToList();

                return new BaseResponse<List<GetAllSubCategoriesWithClassesListVM>>(ResponseMessage, true, 200, Response);
            }
            else
            {
                List<Category> CategoriesEntities = await _CategoryRepository
                    .Where(x => x.Cycle.Status == Domain.Constants.Common.Status.Active &&
                        x.ParentId != null)
                    .Include(x => x.Parent!)
                    .ToListAsync();

                List<CategoryEducationalClass> CategoryEducationalClassEntities = await _CategoryEducationalClassRepository
                    .Where(x => CategoriesEntities.Select(y => y.Id).Contains(x.CategoryId))
                    .ToListAsync();

                List<GetAllSubCategoriesWithClassesListVM> Response = CategoriesEntities
                    .Select(x => new GetAllSubCategoriesWithClassesListVM()
                    {
                        Id = x.Id,
                        CategoryName = Request.lang == "en"
                            ? x.EnglishName
                            : x.ArabicName,
                        RelatedToClasses = x.RelatedToClasses,
                        Classes = CategoryEducationalClassEntities
                            .Where(y => y.CategoryId == x.Id)
                            .Select(y => new ClassesDto()
                            {
                                Id = y.Id,
                                ClassName = Request.lang == "en"
                                    ? y.EducationalClass!.EnglishName
                                    : y.EducationalClass!.ArabicName
                            }).ToList()
                    }).ToList();

                return new BaseResponse<List<GetAllSubCategoriesWithClassesListVM>>(ResponseMessage, true, 200, Response);
            }
        }
    }
}
