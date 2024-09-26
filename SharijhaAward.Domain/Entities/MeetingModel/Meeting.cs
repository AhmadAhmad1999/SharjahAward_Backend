using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Domain.Entities.MeetingModel
{
    public class Meeting : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;
        public string? ArabicText { get; set; }
        public string? EnglishText { get; set; }
        public DateTime Date { get; set; }
        public MeetingTypes Type { get; set; }
        public string? MeetingLink { get; set; }
        public bool isImplemented { get; set; }
        public bool isCanceled { get; set; }
        public string? EnglishReasonOfCanceling { get; set; }
        public string? ArabicReasonOfCanceling { get; set; }
    }
}
