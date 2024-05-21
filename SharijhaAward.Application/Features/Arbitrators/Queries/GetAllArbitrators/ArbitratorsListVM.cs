namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators
{
    public class ArbitratorsListVM
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool isChairman { get; set; } = false;
        public List<ArbitratorCategoryListVM> AtbitratorCategories { get; set; } = new List<ArbitratorCategoryListVM>();
    }
}
