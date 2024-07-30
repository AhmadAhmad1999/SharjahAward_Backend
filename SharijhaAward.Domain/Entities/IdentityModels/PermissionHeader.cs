using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.IdentityModels
{
    public class PermissionHeader : AuditableEntity
    {
        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
    }
}
