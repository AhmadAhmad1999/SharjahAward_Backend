using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.SubscriberModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopSubscriberModel;
using SharijhaAward.Domain.Entities.TrainingWrokshopeAttachments;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.TrainingWorkshopModel; 

public class TrainingWorkshop : AuditableEntity
{
    public Guid Id { get; set; }
    
    public string ArabicTitle { get; set; } = string.Empty;
    
    public string EnglishTitle { get; set; } = string.Empty; 
    public string ArabicDescription { get; set; } = string.Empty;
    
    public string EnglishDescription { get; set; } = string.Empty;
    public string TypeOfAttachment {  get; set; } = string.Empty;
    
 
    public string Thumbnail { get; set; } = string.Empty;

    public Category Category { get; set; } = null!;

    [ForeignKey(nameof(Category))]
    public Guid CategoryId { get; set; }



    // navigation property to the subscriber -> many-to-many relation
    public virtual List<TrainingWrokshopeAttachment> Attachments { get; set; } = new();
    public virtual List<Subscriber> Subscribers { get; set; } = new();
    public virtual List<TrainingWorkshopSubscriber> TrainingWorkshopSubscribers { get; set; } = new();
    
}