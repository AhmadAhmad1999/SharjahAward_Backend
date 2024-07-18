using SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevel;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevelGroupedByClasses
{
    public class GetWinnersByLevelGroupedByClassesListVM
    {
        public int ClassId { get; set; }
        public string? ClassName { get; set; }
        public GetWinnersByLevelMainResponse GetWinnersByLevelMainResponse { get; set; } = new GetWinnersByLevelMainResponse();
    }
}
