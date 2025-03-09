using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class DependencyValidation : AuditableEntity
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int DependencyGroupId { get; set; }
        public DependencyGroup? DependencyGroup { get; set; }
        public int AttributeOperationId { get; set; }
        public AttributeOperation? AttributeOperation { get; set; }
    }
}
