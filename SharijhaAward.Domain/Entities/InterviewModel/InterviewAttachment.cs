using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.InterviewModel
{
    public class InterviewAttachment : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string AttachementPath { get; set; } = null!;
        public int InterviewId { get; set; }
        public Interview? Interview { get; set; }
    }
}
