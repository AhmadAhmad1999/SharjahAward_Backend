using SharijhaAward.Domain.Model.AchievementModel;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.IdentityModels;
using SharijhaAward.Domain.Model.SubscriberAchievementModel;

namespace SharijhaAward.Domain.Model.AchievementClassificationModel; 

public class AchievementClassification : AuditInformation<User> {
    public Guid Id { get; set; }
    // the arabic title of the classification
    public string ArabicTitle { get; set; } = string.Empty;
    
    // the english title of the classification
    public string EnglishTitle { get; set; } = string.Empty;
    
    // navigation property to the Subscriber Achievements 
    public virtual List<SubscriberAchievement> SubscriberAchievements { get; set; } = new();

    public virtual List<Achievement> Achievements { get; set; } = new();
}