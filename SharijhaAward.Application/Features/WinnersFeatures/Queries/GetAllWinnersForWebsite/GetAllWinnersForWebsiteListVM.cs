namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersForWebsite
{
    public class GetAllWinnersForWebsiteListVM
    {
        public int FormId { get; set; }
        public string SubscriberName { get; set; } = null!;
        public string? EducationalEntityName { get; set; }
        public int WinningLevel { get; set; }
    }
}
