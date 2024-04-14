using SharijhaAward.Application.Features.Classes.Queries.GetAllCategoryClassesByCategoryId;

namespace SharijhaAward.Application.Features.Categories.Queries.GetCategoriesWithSubcategories
{
    public class SubcategoriesListVM
    {
        public int Id {  get; set; }
        public string Icon { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public bool? RelatedToClasses { get; set; }
        public List<GetAllCategoryClassesByCategoryIdDto> SubCategoryClasses { get; set; } = new List<GetAllCategoryClassesByCategoryIdDto>();
    }
}
