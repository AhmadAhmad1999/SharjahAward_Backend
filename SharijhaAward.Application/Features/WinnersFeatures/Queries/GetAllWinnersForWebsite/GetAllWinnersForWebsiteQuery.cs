using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersForWebsite
{
    public class GetAllWinnersForWebsiteQuery : IRequest<BaseResponse<List<GetAllWinnersForWebsiteMainResponse>>>
    {
        public int CycleId { get; set; }
        public string? lang { get; set; }
    }
}
