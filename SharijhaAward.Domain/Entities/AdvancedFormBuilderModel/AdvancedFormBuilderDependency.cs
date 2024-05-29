using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Domain.Entities.AdvancedFormBuilderModel
{
    public class AdvancedFormBuilderDependency : AuditableEntity
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int MainAdvancedFormBuilderId { get; set; }
        public AdvancedFormBuilder? MainAdvancedFormBuilder { get; set; }
        public int AdvancedFormBuilderDependencyGroupId { get; set; }
        public AdvancedFormBuilderDependencyGroup? AdvancedFormBuilderDependencyGroup { get; set; }
        public int? AdvancedFormBuilderId { get; set; }
        public AdvancedFormBuilder? AdvancedFormBuilder { get; set; }
        public int? StaticAttributeId { get; set; }
        public StaticAttribute? StaticAttribute { get; set; }
        public int AttributeOperationId { get; set; }
        public AttributeOperation? AttributeOperation { get; set; }
    }
}
