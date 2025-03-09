using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersDashboard
{
    public class GetAllWinnersDashboardQuery : IRequest<BaseResponse<List<GetAllWinnersDashboardListVM>>>
    {
        public string? SubscriberName { get; set; }
        public bool GetDataRandomly { get; set; }
        public int? CategoryId { get; set; }
        public int? CycleId { get; set; }
        public int? CycleNumber { get; set; }
        public string? CycleYear { get; set; }
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int PerPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
