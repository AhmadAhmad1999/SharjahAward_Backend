namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById
{
    public class DependencyValidationDto
    {
        public int DependencyValidationId { get; set; }
        public string Value { get; set; } = null!;
        public int AttributeOperationId { get; set; }
        public string Operation { get; set; } = null!;
        public List<DependencyDto> Dependencies { get; set; } = null!;
    }
}
