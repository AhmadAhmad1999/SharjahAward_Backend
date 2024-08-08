using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetAllUsers
{
    public class GetAllUsersListVM
    {
        public int Id { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public List<GetAllUserRolesDto> UserRoles { get; set; } = new List<GetAllUserRolesDto>();
    }
}
