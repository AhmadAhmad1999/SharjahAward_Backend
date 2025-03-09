using System.ComponentModel.DataAnnotations;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.Common;

namespace SharijhaAward.Domain.Entities.CycleModel
{
    public class Cycle : AuditableEntity
    {
        public int Id { get; set; }
        public int CycleNumber { get; set; }
        public string Year { get; set; } = string.Empty;
        [MinLength(ValidationConstants.ArabicNameMinLength)]
        [MaxLength(ValidationConstants.ArabicNameMaxLength)]
        public string ArabicName { get; set; } = string.Empty;
        [MinLength(ValidationConstants.EnglishNameMinLength)]
        [MaxLength(ValidationConstants.EnglishNameMaxLength)]
        public string EnglishName { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.Close;
        public DateTime RegistrationPortalOpeningDate { get; set; }
        public DateTime RegistrationPortalClosingDate { get; set; }
        public DateTime? SubscriberPortalClosingDate { get; set; }

        [Range(ValidationConstants.IndividualCategoryNumberMinValue, ValidationConstants.IndividualCategoryNumberMaxValue)]
        public int IndividualCategoryNumber { get; set; } = 0;

        [Range(ValidationConstants.GroupCategoryNumberMinValue, ValidationConstants.GroupCategoryNumberMaxValue)]
        public int GroupCategoryNumber { get; set; } = 0;

        public int TheUpperLimitForObtainingInformation { get; set; }
    }
}