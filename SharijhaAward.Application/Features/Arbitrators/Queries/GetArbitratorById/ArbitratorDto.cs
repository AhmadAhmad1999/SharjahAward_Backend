using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById
{
    public class ArbitratorDto
    {
        public int Id { get; set; }
        // [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = string.Empty;
        // [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = string.Empty;
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = string.Empty;
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;
        public bool isChairman { get; set; } = false;
        public string? lang { get; set; }
        public List<ArbitratorCategoryDto> ArbitratorCategories { get; set; } = new List<ArbitratorCategoryDto>();
    }
}
