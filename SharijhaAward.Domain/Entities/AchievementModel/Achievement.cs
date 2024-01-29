using SharijhaAward.Domain.Constants.AchievementConstant;
using SharijhaAward.Domain.Model.AchievementClassificationModel;
using SharijhaAward.Domain.Model.SubscriberModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.AchievementModel
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
