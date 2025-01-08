namespace SharijhaAward.Application.Features.NewsTickerFeatures.Queries.GetNewsTickerById
{
    public class GetNewsTickerByIdDto
    {
        public int Id { get; set; }
        public string ArabicText { get; set; } = null!;
        public string EnglishText { get; set; } = null!;
        public bool isActive { get; set; }
    }
}
