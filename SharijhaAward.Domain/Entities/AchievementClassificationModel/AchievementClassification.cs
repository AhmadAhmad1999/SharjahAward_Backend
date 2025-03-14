﻿using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.AchievementClassificationModel; 

public class AchievementClassification : AuditInformation<User> {
    public int Id { get; set; }
    // the arabic title of the classification
    public string ArabicTitle { get; set; } = string.Empty;
    
    // the english title of the classification
    public string EnglishTitle { get; set; } = string.Empty;
    
    // navigation property to the Subscriber Achievements 
    //public virtual List<SubscriberAchievement> SubscriberAchievements { get; set; } = new();

    //public virtual List<Achievement> Achievements { get; set; } = new();
}