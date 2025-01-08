using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.NewsTickerModel
{
    public class NewsTicker : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicText { get; set; } = null!;
        public string EnglishText { get; set; } = null!;
        public bool isActive { get; set; }
    }
}
