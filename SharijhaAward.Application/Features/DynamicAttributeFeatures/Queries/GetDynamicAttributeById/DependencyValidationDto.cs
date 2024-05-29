namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById
{
    public class DependencyValidationDto
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public string Operation { get; set; } = null!;
        public List<DependencyDto> Dependencies { get; set; } = null!;
    }
}
