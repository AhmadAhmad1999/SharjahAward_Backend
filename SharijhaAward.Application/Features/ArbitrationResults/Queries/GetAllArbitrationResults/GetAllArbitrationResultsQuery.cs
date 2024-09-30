using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.ArbitrationResults.Queries.GetAllArbitrationResults
{
    public class GetAllArbitrationResultsQuery : IRequest<BaseResponse<List<GetAllArbitrationResultsListVM>>>
    {
        public int? CategoryId { get; set; }
        public string? SubscriberName { get; set; }
        public int? CycleNumber { get; set; }
        public string? CategoryName { get; set; }
        public bool? EligibleToWin { get; set; }
        public string? lang { get; set; }
        public string? Token { get; set; }
        public int page { get; set; } = 1;
        public int PerPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
