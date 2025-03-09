namespace SharijhaAward.Application.Features.Categories.Queries.GetAllSubCategoriesWithClasses
{
    public class GetAllSubCategoriesWithClassesListVM
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool? RelatedToClasses { get; set; }
        public List<ClassesDto> Classes { get; set; } = new List<ClassesDto>();

        public DateTime? SortingFormsStartDate { get; set; }
        public DateTime? SortingFormsEndDate { get; set; }
        public DateTime? InitialArbitrationStartDate { get; set; }
        public DateTime? InitialArbitrationEndDate { get; set; }
        public DateTime? ArbitrationAuditStartDate { get; set; }
        public DateTime? ArbitrationAuditEndDate { get; set; }
        public DateTime? FinalArbitrationStartDate { get; set; }
        public DateTime? FinalArbitrationEndDate { get; set; }
        public int MarginOfDifferenceBetweenArbitrators { get; set; }
    }
}
