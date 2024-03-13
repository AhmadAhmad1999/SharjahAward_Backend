using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.SubscriberModel;

namespace SharijhaAward.Domain.Entities.RelatedAccountModel
{
    public class RelatedAccountRequest : AuditableEntity
    {
        public int Id { get; set; }
        public Guid SenderId { get; set; }
        public Subscriber? Sender { get; set; }
        public Guid ReceiverId { get; set; }
        public Subscriber? Receiver { get; set; }
    }
}
