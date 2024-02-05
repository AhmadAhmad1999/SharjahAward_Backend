using SharijhaAward.Domain.Constants.Common;
using SharijhaAward.Domain.Entities.AchievementModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.MeetingSubscriberModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using SharijhaAward.Domain.Entities.RelatedAccountModel;
using SharijhaAward.Domain.Entities.SubscriberAchievementModel;
using SharijhaAward.Domain.Entities.SubscriberInterviewModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopSubscriberModel;
using Microsoft.EntityFrameworkCore;

namespace SharijhaAward.Domain.Entities.SubscriberModel; 


public class Subscriber : User
{
    
    // subscription date
    public DateTime SubscriptionDate { get; set; }
    // status (active, inactive)
    public Status Status { get; set; }
    // identity number
    public string IdentityNumber { get; set; } = string.Empty;

    // navigation property to the related accounts.
    public virtual List<RelatedAccount> RelatedAccounts { get; set; } = new();
    
    public virtual List<ProvidedForm> ProvidedForms { get; set; } = new();
    
    // navigation property to the training workshop => many-to-many relation
    public virtual List<TrainingWorkshop> TrainingWorkshops { get; set; } = new();
    public virtual  List<TrainingWorkshopSubscriber> TrainingWorkshopSubscribers { get; set; } = new();
    
    // navigation property to the SubscriberAchievements
    public virtual List<SubscriberAchievement> SubscriberAchievements { get; set; } = new();

    public virtual List<MeetingSubscriber>MeetingSubscribers { get; set; } = new();

    public virtual List<Achievement> Achievements { get; set; } = new();

    public virtual List<SubscriberInterview> SubscriberInterviews { get; set; } = new();
}