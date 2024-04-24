using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.NotificationTemplateModel
{
    public class NotificationTemplate : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string ArabicBody { get; set; } = null!;
        public string EnglishBody { get; set; } = null!;
    }
}
