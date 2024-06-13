namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevel
{
    public class GetWinnersByLevelMainResponse
    {
        public List<GetWinnersByLevelListVM> RequestedWinners { get; set; } = new List<GetWinnersByLevelListVM>();
        public List<GetWinnersByLevelListVM> RemainingWinners { get; set; } = new List<GetWinnersByLevelListVM>();
    }
}
