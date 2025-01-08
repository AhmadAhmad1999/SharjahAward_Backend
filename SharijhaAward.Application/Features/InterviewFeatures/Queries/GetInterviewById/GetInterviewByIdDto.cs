using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetInterviewById
{
    public class GetInterviewByIdDto
    {
        public int Id { get; set; }

        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;

        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;

        public string? ArabicText { get; set; }
        public string? EnglishText { get; set; }

        public DateTime StartDate { get; set; }

        public MeetingTypes Type { get; set; }
        public string? Address { get; set; }

        public int PeriodOfEachInviteeInMinutes { get; set; }

        public List<InterviewInviteeDto> Invitees { get; set; } = new List<InterviewInviteeDto>();
    }
}
