using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.NotificationModel
{
    public class UserNotification : AuditableEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int NotificationId { get; set; }
        public Notification? Notification { get; set; }
        public bool isReaded { get; set; }
        public string? Action { get; set; }
    }
}
