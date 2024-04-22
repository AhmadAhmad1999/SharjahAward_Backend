using SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllArbitratorsForArbitration
{
    public class GetAllArbitratorsForArbitrationListVM
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        // public string ArbitrationLanguage { get; set; } = null!;
        public int NumberOfRejectedAssignedForms { get; set; }
        public int NumberOfAcceptedAssignedForms { get; set; }
        public List<ArbitratorCategoryListVM> AtbitratorCategories { get; set; } = new List<ArbitratorCategoryListVM>();
    }
}
