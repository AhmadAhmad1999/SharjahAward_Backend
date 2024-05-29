namespace SharijhaAward.Application.Features.DynamicAttributeFeaturesFeatures.Commands.CreateDynamicAttribute
{
    public class CreateDependency
    {
        public string Value { get; set; } = null!;
        public int? DynamicAttributeId { get; set; }
        public int? StaticAttributeId { get; set; }
        public int AttributeOperationId { get; set; }
    }
}
