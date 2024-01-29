using SharijhaAward.Domain.Constants.Common;
using SharijhaAward.Domain.Model.AchievementModel;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.IdentityModels;
using SharijhaAward.Domain.Model.MeetingSubscriberModel;
using SharijhaAward.Domain.Model.ProvidedFormModel;
using SharijhaAward.Domain.Model.RelatedAccountModel;
using SharijhaAward.Domain.Model.SubscriberAchievementModel;
using SharijhaAward.Domain.Model.SubscriberInterviewModel;
using SharijhaAward.Domain.Model.TrainingWorkshopModel;
using SharijhaAward.Domain.Model.TrainingWorkshopSubscriberModel;
using Microsoft.EntityFrameworkCore;

namespace SharijhaAward.Domain.Model.SubscriberModel; 

[Index(nameof(UserId), IsUnique = true)]
public class Subscriber : AuditInformation<User> {
    public Guid Id { get; set; }
    // subscription date
    public DateTime SubscriptionDate { get; set; }
    // status (active, inactive)
    public Status Status { get; set; }
    // identity number
    public string IdentityNumber { get; set; } = string.Empty;
    
    // navigation property to the user table
    public User User { get; set; } = null!;
    public Guid UserId { get; set; }
    
    
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