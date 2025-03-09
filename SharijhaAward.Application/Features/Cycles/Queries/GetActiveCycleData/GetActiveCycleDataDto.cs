using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Domain.Constants.Common;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetActiveCycleData
{
    public class GetActiveCycleDataDto
    {
        public int Id { get; set; }
        public int CycleNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        public DateTime RegistrationPortalOpeningDate { get; set; }
        public DateTime RegistrationPortalClosingDate { get; set; }
        public DateTime? SubscriberPortalClosingDate { get; set; }
    }
}
