using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.SubscriberModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopSubscriberModel;

namespace SharijhaAward.Domain.Entities.TrainingWorkshopModel; 

public class TrainingWorkshop : AuditInformation<User> {
    public Guid Id { get; set; }
    // arabic title of the training workshop
    public string ArabicTitle { get; set; } = string.Empty;
    // english title of the training workshop
    public string EnglishTitle { get; set; } = string.Empty;
    // arabic version of the workshop attachment => file
    public string ArabicWorkshopAttachment { get; set; } = string.Empty;
    // english version of the workshop attachment => file
    public string EnglishWorkshopAttachment { get; set; } = string.Empty;
    // workshop icon
    public string Icon { get; set; } = string.Empty;
    
    
    // navigation property to the subscriber -> many-to-many relation
    public virtual List<Subscriber> Subscribers { get; set; } = new();
    public virtual List<TrainingWorkshopSubscriber> TrainingWorkshopSubscribers { get; set; } = new();

}