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
        public string ArabicFullName { get; set; } = null!;
        public string EnglishFullName { get; set; } = null!;
        public string EnglishOccupation { get; set; } = null!;
        public string ArabicOccupation { get; set; } = null!;
    }
}
