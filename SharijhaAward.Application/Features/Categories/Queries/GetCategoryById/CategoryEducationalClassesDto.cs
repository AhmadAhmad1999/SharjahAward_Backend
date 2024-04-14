namespace SharijhaAward.Application.Features.Categories.Queries.GetCategoryById
{
    public class CategoryEducationalClassesDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int NumberOfExpectedWinners { get; set; }
    }
}
