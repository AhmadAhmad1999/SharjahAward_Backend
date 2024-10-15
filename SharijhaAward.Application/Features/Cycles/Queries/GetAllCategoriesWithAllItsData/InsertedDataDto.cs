namespace SharijhaAward.Application.Features.Cycles.Queries.GetAllCategoriesWithAllItsData
{
    public class InsertedDataDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ParentId { get; set; }
    }
}
