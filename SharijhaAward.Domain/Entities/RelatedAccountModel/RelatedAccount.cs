using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.SubscriberModel;

namespace SharijhaAward.Domain.Entities.RelatedAccountModel
{
    public class RelatedAccount : AuditableEntity
    {
        public int Id { get; set; }
        public Guid Subscriber1Id { get; set; }
        public Subscriber? Subscriber1 { get; set; }
        public Guid Subscriber2Id { get; set; }
        public Subscriber? Subscriber2 { get; set; }
    }
}