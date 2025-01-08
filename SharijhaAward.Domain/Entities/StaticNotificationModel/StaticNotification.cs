using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.StaticNotificationModel
{
    public class StaticNotification : AuditableEntity
    {
        public int Id { get; set; }
        public StaticNotificationTypes StaticNotificationType { get; set; }
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string ArabicBody { get; set; } = null!;
        public string EnglishBody { get; set; } = null!;
        public bool isActive { get; set; }
    }
}
