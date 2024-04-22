namespace SharijhaAward.Application.Features.RoleFeatures.Queries.GetRoleById
{
    public class GetRoleByIdDto
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public List<int> PermissionsIds { get; set; } = new List<int>();
    }
}
