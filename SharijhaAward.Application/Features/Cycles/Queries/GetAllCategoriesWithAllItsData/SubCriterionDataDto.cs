namespace SharijhaAward.Application.Features.Cycles.Queries.GetAllCategoriesWithAllItsData
{
    public class SubCriterionDataDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<InsertedDataDto> SubCriterionItemDataDto { get; set; } = new List<InsertedDataDto>();
    }
}
