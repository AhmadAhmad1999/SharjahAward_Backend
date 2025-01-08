namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetInterviewById
{
    public class InterviewInviteeParticipantDto
    {
        public int Id { get; set; }

        public int InterviewInviteeId { get; set; }

        public string? ExternalUserEmail { get; set; }

        public int? SubscriberId { get; set; }
        public string? SubscriberEmail { get; set; }

        public int? ArbitratorId { get; set; }
        public string? ArbitratorEmail { get; set; }
        public string? ArbitratorArabicName { get; set; }
        public string? ArbitratorEnglishName { get; set; }

        public bool CanImplementTheInterview { get; set; } = true;
        public string? ReasoneForNotImplementing { get; set; }
    }
}
