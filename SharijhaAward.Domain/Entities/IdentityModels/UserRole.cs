using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.IdentityModels
{
    public class UserRole : AuditableEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
