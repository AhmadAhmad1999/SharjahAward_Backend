using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById
{
    public class ArbitratorDto
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = string.Empty;
        [EmailValidation]
        public string Email { get; set; } = string.Empty;
        public ArbitrationLanguage ArbitrationLanguage { get; set; }
        public bool isChairman { get; set; } = false;
        public string? lang { get; set; }
        public List<ArbitratorCategoryDto> ArbitratorCateogryClasses { get; set; } = new List<ArbitratorCategoryDto>();
    }
}
