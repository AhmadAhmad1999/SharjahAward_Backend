using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.SubscriberModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopSubscriberModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.TrainingWorkshopModel; 

public class TrainingWorkshop : AuditInformation<User> {
    public Guid Id { get; set; }
    
    public string ArabicTitle { get; set; } = string.Empty;
    
    public string EnglishTitle { get; set; } = string.Empty; 
    public string ArabicDescription { get; set; } = string.Empty;
    
    public string EnglishDescription { get; set; } = string.Empty;
    public string TypeOfAttachment {  get; set; } = string.Empty;
    // arabic version of the workshop attachment => file
    public string ArabicWorkshopAttachment { get; set; } = string.Empty;
    // english version of the workshop attachment => file
    public string EnglishWorkshopAttachment { get; set; } = string.Empty;
 
    public string Thumbnale { get; set; } = string.Empty;

    public Category Category { get; set; } = null!;

    [ForeignKey(nameof(Category))]
    public Guid CategoryId { get; set; }


    
    // navigation property to the subscriber -> many-to-many relation
    public virtual List<Subscriber> Subscribers { get; set; } = new();
    public virtual List<TrainingWorkshopSubscriber> TrainingWorkshopSubscribers { get; set; } = new();

}