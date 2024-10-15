namespace SharijhaAward.Application.Features.Cycles.Queries.GetAllCategoriesWithAllItsData
{
    public class MainCriterionDataDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<SubCriterionDataDto> SubCriterionDataDto { get; set; } = new List<SubCriterionDataDto>();
    }
}
