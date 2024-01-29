using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.IdentityModels;
using SharijhaAward.Domain.Model.SubscriberModel;
using SharijhaAward.Domain.Model.TrainingWorkshopModel;

namespace SharijhaAward.Domain.Model.TrainingWorkshopSubscriberModel; 

public class TrainingWorkshopSubscriber : AuditInformation<User> {
    [Key]
    public int Id {  get; set; }
    // navigation property to the Subscriber
    public Subscriber Subscriber { get; set; } = null!;
    [ForeignKey(nameof(Subscriber))]
    public Guid SubscribersId { get; set; }
    
    // navigation property to the TrainingWorkshop
    public TrainingWorkshop TrainingWorkshop { get; set; } = null!;
    [ForeignKey(nameof(TrainingWorkshop))]
    public Guid TrainingWorkshopsId { get; set; }

}