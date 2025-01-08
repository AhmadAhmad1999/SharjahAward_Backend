using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.CancelInterviewInvitee
{
    public class CancelInterviewInviteeCommand : IRequest<BaseResponse<object>>
    {
        public int InterviewInviteeId { get; set; }

        [ArabicNameValidation]
        [MaxLength]
        public string ArabicReasonForCancelling { get; set; } = null!;

        [EnglishNameValidation]
        [MaxLength]
        public string EnglishReasonForCancelling { get; set; } = null!;

        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
