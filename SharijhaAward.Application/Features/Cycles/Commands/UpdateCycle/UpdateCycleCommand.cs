using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.Common;

namespace SharijhaAward.Application.Features.Cycles.Commands.UpdateCycle
{
    public class UpdateCycleCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public int CycleNumber { get; set; }
        public string Year { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        public Status Status { get; set; }
        public DateTime RegistrationPortalOpeningDate { get; set; }
        public DateTime RegistrationPortalClosingDate { get; set; }
        public DateTime? SubscriberPortalClosingDate { get; set; }

        public int IndividualCategoryNumber { get; set; } = 0;
        public int GroupCategoryNumber { get; set; } = 0;
        public int TheUpperLimitForObtainingInformation { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
