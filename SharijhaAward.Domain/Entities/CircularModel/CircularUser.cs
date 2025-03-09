using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.CircularModel
{
    public class CircularUser : AuditableEntity
    {
        public int Id { get; set; }
        public int CircularId { get; set; }
        public Circular? Circular { get; set; }
        public int UserRoleId { get; set; }
        public UserRole? UserRole { get; set; }
        public bool IsRead { get; set; } = false;
    }
}
