using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.InterviewModel
{
    public class InterviewInviteeNoteAndQuestion : AuditableEntity
    {
        public int Id { get; set; }

        public string ArabicText { get; set; } = null!;
        public string EnglishText { get; set; } = null!;

        public int InterviewInviteeId { get; set; }
        public InterviewInvitee? InterviewInvitee { get; set; }

        public bool isQuestion { get; set; }
    }
}
