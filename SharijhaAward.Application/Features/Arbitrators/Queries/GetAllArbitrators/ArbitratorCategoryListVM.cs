namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators
{
    public class ArbitratorCategoryListVM
    {
        public Guid Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
    }
}
