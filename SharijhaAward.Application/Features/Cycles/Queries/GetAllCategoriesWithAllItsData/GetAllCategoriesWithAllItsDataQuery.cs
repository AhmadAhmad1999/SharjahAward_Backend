using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetAllCategoriesWithAllItsData
{
    public class GetAllCategoriesWithAllItsDataQuery : IRequest<BaseResponse<List<MainCategoryDataDto>>>
    {
        public int CycleId { get; set; }
        public string? lang { get; set; }
    }
}
