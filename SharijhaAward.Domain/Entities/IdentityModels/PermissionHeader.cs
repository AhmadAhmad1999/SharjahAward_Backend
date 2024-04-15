using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.IdentityModels
{
    public class PermissionHeader : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
