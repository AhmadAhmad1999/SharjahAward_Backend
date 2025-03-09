namespace SharijhaAward.Application.Features.NotificationFeatures.Queries.GetAllNotificationsByFCM_Token_Mobile
{
    public class GetAllNotificationsByFCM_Token_MobileListVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public bool isReaded { get; set; }
        public string? Action { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
