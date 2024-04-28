using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllSubCategories
{
    public class GetAllSubCategoriesHandler 
        : IRequestHandler<GetAllSubCategoriesQuery, BaseResponse<List<GetAllSubCategoriesListVM>>>
    {
        private readonly IAsyncRepository<Category> _CategoryRepository;

        public GetAllSubCategoriesHandler(IAsyncRepository<Category> CategoryRepository)
        {
            _CategoryRepository = CategoryRepository;
        }

        public async Task<BaseResponse<List<GetAllSubCategoriesListVM>>> 
            Handle(GetAllSubCategoriesQuery Request, CancellationToken cancellationToken)
        {
            List<GetAllSubCategoriesListVM> CategoriesEntities = await _CategoryRepository
                .Where(x => x.ParentId == null)
                .OrderByDescending(x => x.CreatedAt)
                .Select(x => new GetAllSubCategoriesListVM()
                {
                    Id = x.Id,
                    CategoryName = Request.lang == "en"
                        ? x.EnglishName
                        : x.ArabicName
                }).ToListAsync();

            return new BaseResponse<List<GetAllSubCategoriesListVM>>(string.Empty, true, 200, CategoriesEntities);
        }
    }
}
