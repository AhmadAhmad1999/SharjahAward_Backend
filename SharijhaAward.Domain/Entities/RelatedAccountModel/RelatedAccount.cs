using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.SubscriberModel;

namespace SharijhaAward.Domain.Entities.RelatedAccountModel; 

public class RelatedAccount : AuditInformation<User> {
    public Guid Id { get; set; }
    // related email 
    public string Email { get; set; } = string.Empty;
    
    // navigation property to the subscriber
    public Subscriber Subscriber { get; set; } = null!;
    public Guid SubscriberId { get; set; }
}