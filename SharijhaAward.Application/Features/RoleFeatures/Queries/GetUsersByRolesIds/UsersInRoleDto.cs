using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.RoleFeatures.Queries.GetUsersByRolesIds
{
    public class UsersInRoleDto
    {
        public int Id { get; set; }
        public string? ArabicName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null!;
    }
}
