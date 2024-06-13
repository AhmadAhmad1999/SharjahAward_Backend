namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevel
{
    public class GetWinnersByLevelListVM
    {
        public int FormId { get; set; }
        public string SubscriberName { get; set; } = null!;
        public float FinalScore { get; set; }
    }
}
