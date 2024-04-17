using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllClassesByCategoriesIds
{
    public class GetAllClassesByCategoriesIdsHandler
        : IRequestHandler<GetAllClassesByCategoriesIdsQuery, BaseResponse<List<GetAllClassesByCategoriesIdsListVM>>>
    {
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        public GetAllClassesByCategoriesIdsHandler(IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository)
        {
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
        }

        public async Task<BaseResponse<List<GetAllClassesByCategoriesIdsListVM>>> 
            Handle(GetAllClassesByCategoriesIdsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllClassesByCategoriesIdsListVM> Classes = await _CategoryEducationalClassRepository
                .Where(x => Request.CategoriesIds.Any(y => y == x.CategoryId))
                .OrderByDescending(x => x.CreatedAt)
                .Include(x => x.EducationalClass!)
                .Select(x => x.EducationalClass!)
                .Select(x => new GetAllClassesByCategoriesIdsListVM()
                {
                    Id = x.Id,
                    ArabicName = x.ArabicName,
                    EnglishName = x.EnglishName,
                    Name = Request.lang == "en"
                        ? x.EnglishName
                        : x.ArabicName
                }).ToListAsync();

            return new BaseResponse<List<GetAllClassesByCategoriesIdsListVM>>(ResponseMessage, true, 200, Classes);
        }
    }
}
