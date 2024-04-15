namespace SharijhaAward.Application.Features.RoleFeatures.Queries.GetRoleById
{
    public class RolePermissionHeaderDto
    {
        public string Name { get; set; } = null!;
        public List<RolePermissionsListVM> RolePermissions { get; set; } = new List<RolePermissionsListVM>();
    }
}
