namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById
{
    public class GeneralValidationDto
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public int DynamicAttributeId { get; set; }
        public string? DynamicAttributeLabel { get; set; }
        public int AttributeOperationId { get; set; }
        public string? AttributeOperation { get; set; }
    }
}
