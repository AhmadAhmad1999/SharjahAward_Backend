namespace SharijhaAward.Application.Features.NotificationFeatures.Queries.GetAllNotificationsByFCM_Token
{
    public class GetAllNotificationsByFCM_TokenListVM
    {
        public List<NotificationDto> ReadedNotifications = new List<NotificationDto>();
        
        public List<NotificationDto> UnReadedNotifications = new List<NotificationDto>();

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
