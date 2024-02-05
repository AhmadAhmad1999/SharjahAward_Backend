using SharijhaAward.Domain.Constants.AchievementConstant;
using SharijhaAward.Domain.Entities.AchievementClassificationModel;
using SharijhaAward.Domain.Entities.SubscriberModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.AchievementModel
{
    public class Achievement
    {
        public int Id { get; set; }

        public string ArabicTitle { get; set; }
        public string EnglishTitle { get; set; }

        public string Attachment { get; set; }

        public DateTime Date { get; set; }

        public AchievementStatus Status { get; set; }

        public AchievementClassification Classification { get; set; }

        [ForeignKey(nameof(Classification))]
        public Guid classificationId { get; set; }
    
        public Subscriber Subscriber { get; set; }

        [ForeignKey(nameof(Subscriber))]
        public Guid subscriberId { get; set; }
    }
}
