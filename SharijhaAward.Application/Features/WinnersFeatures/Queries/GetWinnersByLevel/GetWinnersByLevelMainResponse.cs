namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevel
{
    public class GetWinnersByLevelMainResponse
    {
        public List<GetWinnersByLevelGroupByLevelListVM> RequestedWinners { get; set; } = new List<GetWinnersByLevelGroupByLevelListVM>();
        public List<GetWinnersByLevelGroupByLevelListVM> RemainingWinners { get; set; } = new List<GetWinnersByLevelGroupByLevelListVM>();
    }
}
