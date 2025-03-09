using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllCategoriesWithCycleNumber
{
    public class GetAllCategoriesWithCycleNumberHandler
        : IRequestHandler<GetAllCategoriesWithCycleNumberQuery, BaseResponse<List<GetAllCategoriesWithCycleNumberListVM>>>
    {
        private readonly IAsyncRepository<Category> _CategoryRepository;

        public GetAllCategoriesWithCycleNumberHandler(IAsyncRepository<Category> CategoryRepository)
        {
            _CategoryRepository = CategoryRepository;
        }
        public async Task<BaseResponse<List<GetAllCategoriesWithCycleNumberListVM>>> 
            Handle(GetAllCategoriesWithCycleNumberQuery Request, CancellationToken cancellationToken)
        {
            List<GetAllCategoriesWithCycleNumberListVM> CategoriesEntities = await _CategoryRepository
                .OrderByDescending(x => x.CreatedAt, 0, -1)
                .Select(x => new GetAllCategoriesWithCycleNumberListVM()
                {
                    CategoryName = Request.lang == "en"
                        ? x.EnglishName
                        : x.ArabicName,
                    Id = x.Id,
                    CycleNumber = x.Cycle!.CycleNumber,
                    ArbitrationAuditEndDate = x.ArbitrationAuditEndDate,
                    ArbitrationAuditStartDate = x.ArbitrationAuditStartDate,
                    FinalArbitrationEndDate = x.FinalArbitrationEndDate,
                    FinalArbitrationStartDate = x.FinalArbitrationStartDate,
                    InitialArbitrationEndDate = x.InitialArbitrationEndDate,
                    InitialArbitrationStartDate = x.InitialArbitrationStartDate,
                    SortingFormsEndDate = x.SortingFormsEndDate,
                    SortingFormsStartDate = x.SortingFormsStartDate,
                    MarginOfDifferenceBetweenArbitrators = x.MarginOfDifferenceBetweenArbitrators
                }).ToListAsync();

            return new BaseResponse<List<GetAllCategoriesWithCycleNumberListVM>>(string.Empty, true, 200, CategoriesEntities);
        }
    }
}
