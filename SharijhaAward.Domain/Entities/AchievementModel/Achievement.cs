using SharijhaAward.Domain.Constants.AchievementConstant;
using SharijhaAward.Domain.Entities.AchievementClassificationModel;
using SharijhaAward.Domain.Entities.SubscriberModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.AchievementModel
{
    public class Achievement
    {
        public Guid Id { get; set; }
        public string FieldOfDiscrimination { get; set; } =string.Empty;
        public string Projects { get; set; } = string.Empty;
        public string SkillsAndExperiences { get; set; } = string.Empty;

        
    }
}
