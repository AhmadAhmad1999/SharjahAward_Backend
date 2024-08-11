using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.RoleFeatures.Queries.GetUsersByRolesIds
{
    public class UsersInRoleDto
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string? ArabicName { get; set; }
        [EmailValidation]
        public string Email { get; set; } = null!;
    }
}
