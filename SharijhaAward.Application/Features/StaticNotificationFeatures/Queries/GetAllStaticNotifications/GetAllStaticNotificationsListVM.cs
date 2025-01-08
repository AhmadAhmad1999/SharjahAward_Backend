namespace SharijhaAward.Application.Features.StaticNotificationFeatures.Queries.GetAllStaticNotifications
{
    public class GetAllStaticNotificationsListVM
    {
        public int Id { get; set; }
        public string StaticNotificationType { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string ArabicBody { get; set; } = null!;
        public string EnglishBody { get; set; } = null!;
        public bool isActive { get; set; }
    }
}
