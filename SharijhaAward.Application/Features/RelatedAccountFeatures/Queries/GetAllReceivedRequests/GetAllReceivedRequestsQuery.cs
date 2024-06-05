using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllReceivedRequests
{
    public class GetAllReceivedRequestsQuery : IRequest<BaseResponse<List<GetAllReceivedRequestsListVM>>>
    {
        public string? token { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
