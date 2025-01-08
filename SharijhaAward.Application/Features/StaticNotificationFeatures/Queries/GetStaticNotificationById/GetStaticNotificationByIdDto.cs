using SharijhaAward.Domain.Entities.StaticNotificationModel;

namespace SharijhaAward.Application.Features.StaticNotificationFeatures.Queries.GetStaticNotificationById
{
    public class GetStaticNotificationByIdDto
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
