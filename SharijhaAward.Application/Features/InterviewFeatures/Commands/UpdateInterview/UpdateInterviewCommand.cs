using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.UpdateInterview
{
    public class UpdateInterviewCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;

        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;

        public string? ArabicText { get; set; }
        public string? EnglishText { get; set; }

        public DateTime StartDate { get; set; }

        public MeetingTypes Type { get; set; }
        public string? Address { get; set; }

        public int PeriodOfEachInviteeInMinutes { get; set; }

        public List<UpdateInterviewInviteeDto> Invitees { get; set; } = new List<UpdateInterviewInviteeDto>();

        public string? lang { get; set; }
    }
}
