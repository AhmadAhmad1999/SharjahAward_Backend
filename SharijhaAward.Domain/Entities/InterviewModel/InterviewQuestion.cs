using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.InterviewModel
{
    public class InterviewQuestion : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicQuestion { get; set; } = null!;
        public string EnglishQuestion { get; set; } = null!;
        public int InterviewId { get; set; }
        public Interview? Interview { get; set; }
    }
}
