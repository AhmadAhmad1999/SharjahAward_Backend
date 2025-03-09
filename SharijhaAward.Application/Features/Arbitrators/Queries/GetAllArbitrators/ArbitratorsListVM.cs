using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators
{
    public class ArbitratorsListVM
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = null!;
        [EmailValidation]
        public string Email { get; set; } = null!;
        public bool isChairman { get; set; } = false;
        public List<ArbitratorCategoryListVM> AtbitratorCategories { get; set; } = new List<ArbitratorCategoryListVM>();
        public bool isSubcommitteeOfficer { get; set; } = false;
        public List<ArbitratorCategoryListVM> SubcommitteeOfficerCategories { get; set; } = new List<ArbitratorCategoryListVM>();
    }
}
