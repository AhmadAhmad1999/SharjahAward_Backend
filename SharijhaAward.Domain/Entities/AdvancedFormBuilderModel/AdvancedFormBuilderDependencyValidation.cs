using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Domain.Entities.AdvancedFormBuilderModel
{
    public class AdvancedFormBuilderDependencyValidation : AuditableEntity
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int AdvancedFormBuilderDependencyGroupId { get; set; }
        public AdvancedFormBuilderDependencyGroup? AdvancedFormBuilderDependencyGroup { get; set; }
        public int AttributeOperationId { get; set; }
        public AttributeOperation? AttributeOperation { get; set; }
    }
}
