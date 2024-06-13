namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersDashboard
{
    public class GetAllWinnersDashboardListVM
    {
        public int FormId { get; set; }
        public string SubscriberName { get; set; } = null!;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public float InitialArbitrationScore { get; set; }
        public float ArbitrationAuditScore { get; set; }
        public float FinalArbitrationScore { get; set; }
    }
}
