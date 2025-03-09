using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Domain.Constants.Common;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetCycleById
{
    public class CycleDto
    {
        public int Id { get; set; }
        public int CycleNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.InActive;
        public DateTime RegistrationPortalOpeningDate { get; set; }
        public DateTime RegistrationPortalClosingDate { get; set; }
        public DateTime? SubscriberPortalClosingDate { get; set; }
        public int IndividualCategoryNumber { get; set; } = 0;
        public int GroupCategoryNumber { get; set; } = 0;
        public int TheUpperLimitForObtainingInformation { get; set; }
    }
}
