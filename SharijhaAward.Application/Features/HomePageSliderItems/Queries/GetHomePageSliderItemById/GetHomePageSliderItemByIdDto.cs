namespace SharijhaAward.Application.Features.HomePageSliderItems.Queries.GetHomePageSliderItemById
{
    public class GetHomePageSliderItemByIdDto
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
