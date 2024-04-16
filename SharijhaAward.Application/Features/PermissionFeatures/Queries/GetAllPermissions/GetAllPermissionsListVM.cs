namespace SharijhaAward.Application.Features.PermissionFeatures.Queries.GetAllPermissions
{
    public class GetAllPermissionsListVM
    {
        public string Name { get; set; } = null!;
        public List<PermissionListVM> Permissions { get; set; } = new List<PermissionListVM>();
    }
}
