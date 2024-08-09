using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Commands.UpdateCycle
{
    public class UpdateCycleCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public int CycleNumber { get; set; }
        public string Year { get; set; } = string.Empty;
        // [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = string.Empty;
        // [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.InActive;
        public DateTime RegistrationPortalOpeningDate { get; set; }
        public DateTime RegistrationPortalClosingDate { get; set; }
        public DateTime? SubscriberPortalClosingDate { get; set; }
        public DateTime? InitialArbitrationStartDate { get; set; }
        public DateTime? InitialArbitrationEndDate { get; set; }
        public DateTime? FinalArbitrationStartDate { get; set; }
        public DateTime? FinalArbitrationEndDate { get; set; }
        public int IndividualCategoryNumber { get; set; } = 0;
        public int GroupCategoryNumber { get; set; } = 0;
        public int TheUpperLimitForObtainingInformation { get; set; }
        public int MarginOfDifferenceBetweenArbitrators { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
