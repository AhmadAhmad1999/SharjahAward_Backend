using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.IdentityModels
{
    public class Permission : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Action { get; set; } = string.Empty;
        public int PermissionHeaderId { get; set; }
        public PermissionHeader? PermissionHeader { get; set; }
    }
}