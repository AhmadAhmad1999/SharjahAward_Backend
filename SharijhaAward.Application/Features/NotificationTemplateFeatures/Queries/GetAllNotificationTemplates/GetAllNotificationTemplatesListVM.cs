namespace SharijhaAward.Application.Features.NotificationTemplateFeatures.Queries.GetAllNotificationTemplates
{
    public class GetAllNotificationTemplatesListVM
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string ArabicBody { get; set; } = null!;
        public string EnglishBody { get; set; } = null!;
    }
}
