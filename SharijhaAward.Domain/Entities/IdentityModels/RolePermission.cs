using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.IdentityModels
{
    public class RolePermission : AuditableEntity
    {
        public int Id { get; set; }
        public Guid PermissionId { get; set; }
        public Permission? Permission { get; set; }
        public Guid RoleRoleId { get; set; }
        public Role? Role { get; set; }
    }
}
