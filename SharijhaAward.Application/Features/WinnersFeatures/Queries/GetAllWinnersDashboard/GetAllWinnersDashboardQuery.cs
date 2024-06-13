using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersDashboard
{
    public class GetAllWinnersDashboardQuery : IRequest<BaseResponse<List<GetAllWinnersDashboardListVM>>>
    {
        public string? SubscriberName { get; set; }
        public bool GetDataRandomly { get; set; }
        public int? CategoryId { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int PerPage { get; set; }
    }
}
