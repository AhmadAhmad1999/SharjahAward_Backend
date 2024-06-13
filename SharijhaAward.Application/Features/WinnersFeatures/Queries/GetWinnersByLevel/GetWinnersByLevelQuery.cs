using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevel
{
    public class GetWinnersByLevelQuery : IRequest<BaseResponse<GetWinnersByLevelMainResponse>>
    {
        public int CategoryId { get; set; }
        public int MaxLevelOfWinners { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int PerPage { get; set; }
    }
}
