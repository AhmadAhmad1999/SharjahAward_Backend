namespace SharijhaAward.Application.Features.Categories.Queries.GetCategoryById
{
    public class CategoryEducationalClassesDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public int NumberOfExpectedWinners { get; set; }
    }
}
