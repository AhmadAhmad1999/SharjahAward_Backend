using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.RelatedAccountModel
{
    public class RelatedAccount : AuditableEntity
    {
        public int Id { get; set; }
        public int User1Id { get; set; }
        public User? User1 { get; set; }
        public int User2Id { get; set; }
        public User? User2 { get; set; }
    }
}