namespace SharijhaAward.Application.Features.Cycles.Queries.GetAllCategoriesWithAllItsData
{
    public class MainCategoryDataDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<SubCategoryDataDto> SubCriterionDataDto { get; set; } = new List<SubCategoryDataDto>();
    }
}
