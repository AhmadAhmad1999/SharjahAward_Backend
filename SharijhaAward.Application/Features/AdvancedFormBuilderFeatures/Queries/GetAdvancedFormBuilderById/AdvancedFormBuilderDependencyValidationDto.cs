namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAdvancedFormBuilderById
{
    public class AdvancedFormBuilderDependencyValidationDto
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public string Operation { get; set; } = null!;
        public List<AdvancedFormBuilderDependencyDto> Dependencies { get; set; } = null!;
    }
}
