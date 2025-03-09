using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetAllUsers
{
    public class GetAllUsersListVM
    {
        public int Id { get; set; }
        [EmailValidation]
        public string Email { get; set; } = string.Empty;
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = null!;
        public Gender Gender { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<GetAllUserRolesDto> UserRoles { get; set; } = new List<GetAllUserRolesDto>();
    }
}
