namespace SharijhaAward.Application.Features.UserFeatures.Commands.CreateUser
{
    public class UserRoleCategoryDto
    {
        public int RoleId { get; set; }
        public List<int> CategoriesIds { get; set; } = new List<int>();
    }
}
