using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.DigitalSignatureModel
{
    public class DigitalSignature : AuditableEntity
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
