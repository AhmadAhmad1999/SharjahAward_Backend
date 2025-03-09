using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Domain.Constants.Common;

namespace SharijhaAward.Application.Features.Cycles.Queries.ExportToExcel
{
    public class CycleExportDto
    {
        public int Id { get; set; }
        public int CycleNumber { get; set; }
        public string Year { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        public string StatusName { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.Close;
        public DateTime RegistrationPortalOpeningDate { get; set; }
        public DateTime RegistrationPortalClosingDate { get; set; }
        public DateTime? SubscriberPortalClosingDate { get; set; }
        public int IndividualCategoryNumber { get; set; } = 0;
        public int TheUpperLimitForObtainingInformation { get; set; }
        public int GroupCategoryNumber { get; set; } = 0;
    }
}
