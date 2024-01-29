using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.IdentityModels;
using SharijhaAward.Domain.Model.SubscriberModel;

namespace SharijhaAward.Domain.Model.RelatedAccountModel; 

public class RelatedAccount : AuditInformation<User> {
    public Guid Id { get; set; }
    // related email 
    public string Email { get; set; } = string.Empty;
    
    // navigation property to the subscriber
    public Subscriber Subscriber { get; set; } = null!;
    public Guid SubscriberId { get; set; }
}