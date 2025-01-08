namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetInterviewById
{
    public class InterviewInviteeDto
    {
        public int Id { get; set; }

        public int OrderId { get; set; } // Starts From Zero..

        public int InterviewId { get; set; }

        public bool isCancelled { get; set; }
        public string? ArabicReasonForCancelling { get; set; }
        public string? EnglishReasonForCancelling { get; set; }

        public bool isImplemented { get; set; }

        public DateTime StartDate { get; set; } // = Interview.StartDate.AddMinutes(Interview.PeriodOfEachInviteeInMinutes * (This.OrderId + 1))..
        public DateTime EndDate { get; set; } // = This.StartDate.AddMinutes(Interview.PeriodOfEachInviteeInMinutes)..

        // After Creating a New One Using The Create New Microsoft Teams Meeting URL..
        // Required If (Interview.Type == MeetingTypes.Virtual)..
        public string? InviteeLink { get; set; }

        public List<string> ExternalUsersEmails { get; set; } = new List<string>();
        public List<int> ArbitratorsIds { get; set; } = new List<int>();
        public List<int> SubscribersIds { get; set; } = new List<int>();

        public List<InterviewInviteeNoteAndQuestionDto> Notes { get; set; } = new List<InterviewInviteeNoteAndQuestionDto>();
        public List<InterviewInviteeNoteAndQuestionDto> Questions { get; set; } = new List<InterviewInviteeNoteAndQuestionDto>();
    }
}
