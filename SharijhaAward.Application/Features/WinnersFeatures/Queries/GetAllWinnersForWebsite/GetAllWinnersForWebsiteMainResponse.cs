namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersForWebsite
{
    public class GetAllWinnersForWebsiteMainResponse
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public List<GetAllWinnersForWebsiteListVM> Winners { get; set; } = new List<GetAllWinnersForWebsiteListVM>();
    }
}
