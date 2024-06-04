namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetAllUsers
{
    public class GetAllUsersListVM
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public List<GetAllUserRolesDto> UserRoles { get; set; } = new List<GetAllUserRolesDto>();
    }
}
