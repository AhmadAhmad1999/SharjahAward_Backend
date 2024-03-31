namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById
{
    public class ArbitratorCategoryDto
    {
        public Guid Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
    }
}
