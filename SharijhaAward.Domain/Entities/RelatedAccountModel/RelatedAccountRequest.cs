using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.RelatedAccountModel
{
    public class RelatedAccountRequest : AuditableEntity
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public User? Sender { get; set; }
        public int ReceiverId { get; set; }
        public User? Receiver { get; set; }
        public RelatedAccountRequestStatus Status { get; set; }
    }
}
