using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetUserById
{
    public class GetUserByIdDto
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public List<UsersRolesDto> Roles { get; set; } = new List<UsersRolesDto>();
    }
}
