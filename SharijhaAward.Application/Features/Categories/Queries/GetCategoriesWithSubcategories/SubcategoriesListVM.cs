using SharijhaAward.Application.Features.Classes.Queries.GetAllCategoryClassesByCategoryId;
using SharijhaAward.Application.Features.Rewards.Queries.GetAllRewards;

namespace SharijhaAward.Application.Features.Categories.Queries.GetCategoriesWithSubcategories
{
    public class SubcategoriesListVM
    {
        public int Id {  get; set; }
        public string Icon { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool? RelatedToClasses { get; set; }
        public List<GetAllCategoryClassesByCategoryIdDto> SubCategoryClasses { get; set; } = new List<GetAllCategoryClassesByCategoryIdDto>();
        public bool? RelatedToEducationalEntities { get; set; }
        public List<GetAllCategoryEducationalEntitiesByCategoryIdDto> SubCategoryEducationalEntities { get; set; } = new List<GetAllCategoryEducationalEntitiesByCategoryIdDto>();
        public List<RewardListVm> Rewards { get; set; } = null!;
    }
}
