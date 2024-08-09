using SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllArbitratorsForArbitration
{
    public class GetAllArbitratorsForArbitrationListVM
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
        // public string ArbitrationLanguage { get; set; } = null!;
        public int NumberOfRejectedAssignedForms { get; set; }
        public int NumberOfAcceptedAssignedForms { get; set; }
        public List<ArbitratorCategoryListVM> AtbitratorCategories { get; set; } = new List<ArbitratorCategoryListVM>();
    }
}
