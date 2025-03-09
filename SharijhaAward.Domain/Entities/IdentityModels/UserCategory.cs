using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Domain.Entities.IdentityModels
{
    public class UserCategory : AuditableEntity
    {
        public int Id { get; set; }
        public int UserRoleId { get; set; }
        public UserRole? UserRole { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
