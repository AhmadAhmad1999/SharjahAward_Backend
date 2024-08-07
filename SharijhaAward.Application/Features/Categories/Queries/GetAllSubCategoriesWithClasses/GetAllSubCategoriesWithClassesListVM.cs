namespace SharijhaAward.Application.Features.Categories.Queries.GetAllSubCategoriesWithClasses
{
    public class GetAllSubCategoriesWithClassesListVM
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool? RelatedToClasses { get; set; }
        public List<ClassesDto> Classes { get; set; } = new List<ClassesDto>();
    }
}
