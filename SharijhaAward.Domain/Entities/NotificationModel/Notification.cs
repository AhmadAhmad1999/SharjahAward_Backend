using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.NotificationModel
{
    public class Notification : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string ArabicBody { get; set; } = null!;
        public string EnglishBody { get; set; } = null!;
        public bool isStaticNotification { get; set; } = false;
    }
}