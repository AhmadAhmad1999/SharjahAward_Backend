using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.InterviewModel
{
    public class InterviewUser : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int InterviewId { get; set; }
        public Interview? Interview { get; set; }
    }
}
