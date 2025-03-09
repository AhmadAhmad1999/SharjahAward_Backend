namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetAllUserRoleCategoriesByUserId
{
    public class GetAllUserRoleCategoriesByUserIdListVM
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public List<CategoriesDto> CategoriesDto { get; set; } = new List<CategoriesDto>();
    }
}
