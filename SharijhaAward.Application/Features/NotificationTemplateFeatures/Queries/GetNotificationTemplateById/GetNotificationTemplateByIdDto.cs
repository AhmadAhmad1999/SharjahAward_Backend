namespace SharijhaAward.Application.Features.NotificationTemplateFeatures.Queries.GetNotificationTemplateById
{
    public class GetNotificationTemplateByIdDto
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string ArabicBody { get; set; } = null!;
        public string EnglishBody { get; set; } = null!;
    }
}
