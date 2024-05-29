namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAdvancedFormBuilderById
{
    public class AdvancedFormBuilderGeneralValidationDto
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public int AdvancedFormBuilderId { get; set; }
        public string? AdvancedFormBuilderLabel { get; set; }
        public int AttributeOperationId { get; set; }
        public string? AttributeOperation { get; set; }
    }
}
