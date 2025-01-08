namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAdvancedFormBuilderById
{
    public class AdvancedFormBuilderDependencyDto
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int DynamicAttributeId { get; set; }
        public string? AttributeLabel { get; set; }
        public int AttributeOperationId { get; set; }
        public string Operation { get; set; } = null!;
    }
}
