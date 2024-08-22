namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevel
{
    public class GetWinnersByLevelGroupByLevelListVM
    {
        public int? WinningLevel { get; set; }
        public List<GetWinnersByLevelListVM> GetWinnersByLevelListVM { get; set; } = new List<GetWinnersByLevelListVM>();
    }
}
