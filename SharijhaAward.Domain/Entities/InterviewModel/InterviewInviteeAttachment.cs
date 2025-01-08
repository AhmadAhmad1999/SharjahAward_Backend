using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.InterviewModel
{
    public class InterviewInviteeAttachment : AuditableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string AttachementPath { get; set; } = null!;

        public int InterviewInviteeId { get; set; }
        public InterviewInvitee? InterviewInvitee { get; set; }
    }
}
