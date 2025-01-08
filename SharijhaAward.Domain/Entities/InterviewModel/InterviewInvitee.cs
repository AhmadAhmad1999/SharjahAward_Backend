using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.InterviewModel
{
    public class InterviewInvitee : AuditableEntity
    {
        public int Id { get; set; }

        public int OrderId { get; set; } // Starts From Zero..

        public int InterviewId { get; set; }
        public Interview? Interview { get; set; }

        public bool isCancelled { get; set; }
        public string? ArabicReasonForCancelling { get; set; }
        public string? EnglishReasonForCancelling { get; set; }

        public bool isImplemented { get; set; }

        public DateTime StartDate { get; set; } // = Interview.StartDate.AddMinutes(Interview.PeriodOfEachInviteeInMinutes * (This.OrderId + 1))..
        public DateTime EndDate { get; set; } // = This.StartDate.AddMinutes(Interview.PeriodOfEachInviteeInMinutes)..

        // After Creating a New One Using The Create New Microsoft Teams Meeting URL..
        // Required If (Interview.Type == MeetingTypes.Virtual)..
        public string? InviteeLink { get; set; } 
    }
}
