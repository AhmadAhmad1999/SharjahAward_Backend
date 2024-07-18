using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevelGroupedByClasses
{
    public class GetWinnersByLevelGroupedByClassesQuery : IRequest<BaseResponse<List<GetWinnersByLevelGroupedByClassesListVM>>>
    {
        public int CategoryId { get; set; }
        public int MaxLevelOfWinners { get; set; }
        public string? lang { get; set; }
    }
}
