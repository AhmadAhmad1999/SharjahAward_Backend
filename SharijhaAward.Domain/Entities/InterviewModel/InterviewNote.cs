using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.InterviewModel
{
    public class InterviewNote : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicNote { get; set; } = null!;
        public string EnglishNote { get; set; } = null!;
        public int InterviewId { get; set; }
        public Interview? Interview { get; set; }
    }
}
