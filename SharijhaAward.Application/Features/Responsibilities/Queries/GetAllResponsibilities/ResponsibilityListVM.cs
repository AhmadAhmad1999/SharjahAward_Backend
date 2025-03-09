namespace SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilities
{
    public class ResponsibilityListVM
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public int RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public List<ResponsibilityUserDto>? ResponsibilityUsers { get; set; }
    }
}
