using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Domain.Entities.AdvancedFormBuilderModel
{
    public class AdvancedFormBuilderGeneralValidation : AuditableEntity
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public int AdvancedFormBuilderId { get; set; }
        public AdvancedFormBuilder? AdvancedFormBuilder { get; set; }
        public int AttributeOperationId { get; set; }
        public AttributeOperation? AttributeOperation { get; set; }
    }
}
