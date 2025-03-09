using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.ExportToExcel
{
    public class ArbitratorExportVM
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
        public bool isSubcommitteeOfficer { get; set; } = false;
    }
}
