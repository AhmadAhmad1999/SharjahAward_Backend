namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.CreateInterview
{
    public class CreateInterviewInviteeDto
    {
        public int OrderId { get; set; } // Starts From Zero..

        // public int InterviewId { get; set; }

        //public bool isCancelled { get; set; } = false;
        //public string? ArabicReasonForCancelling { get; set; } = null;
        //public string? EnglishReasonForCancelling { get; set; } = null;

        public bool isImplemented { get; set; } = false;

        // = Interview.StartDate.AddMinutes(Interview.PeriodOfEachInviteeInMinutes * (This.OrderId + 1))..
        // public DateTime StartDate { get; set; } 

        // = This.StartDate.AddMinutes(Interview.PeriodOfEachInviteeInMinutes)..
        // public DateTime EndDate { get; set; }

        // After Creating a New One Using The Create New Microsoft Teams Meeting URL..
        // Required If (Interview.Type == MeetingTypes.Virtual)..
        public string? InviteeLink { get; set; }

        public List<string> ExternalUsersEmails { get; set; } = new List<string>();
        public List<int> ArbitratorsIds { get; set; } = new List<int>();
        public List<int> SubscribersIds { get; set; } = new List<int>();

        public List<CreateInterviewInviteeNoteAndQuestionDto> Notes { get; set; } = new List<CreateInterviewInviteeNoteAndQuestionDto>();
        public List<CreateInterviewInviteeNoteAndQuestionDto> Questions { get; set; } = new List<CreateInterviewInviteeNoteAndQuestionDto>();
    }
}
