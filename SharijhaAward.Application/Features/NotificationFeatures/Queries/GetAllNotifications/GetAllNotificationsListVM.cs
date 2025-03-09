namespace SharijhaAward.Application.Features.NotificationFeatures.Queries.GetAllNotifications
{
    public class GetAllNotificationsListVM
    {
        
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string ArabicBody { get; set; } = null!;
        public string EnglishBody { get; set; } = null!;
        public bool isReaded { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string? Action { get; set; }
        
        public DateTime CreatedAt { get; set; }

    }
}
