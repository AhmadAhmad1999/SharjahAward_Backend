using SharijhaAward.Application.Features.NotificationFeatures.Queries.GetAllNotifications;

namespace SharijhaAward.Application.Features.NotificationFeatures.Queries.GetAllNotificationsByFCM_Token
{
    public class GetAllNotificationsByFCM_TokenListVM
    {
        public string Test { get; set; } = "Malek";
        public List<GetAllNotificationsListVM>? ReadedNotifications { get; set; } = new List<GetAllNotificationsListVM>();


        public List<GetAllNotificationsListVM>? UnReadedNotifications { get; set; } = new List<GetAllNotificationsListVM>();

    }
    public class NotificationDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public bool isReaded { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
