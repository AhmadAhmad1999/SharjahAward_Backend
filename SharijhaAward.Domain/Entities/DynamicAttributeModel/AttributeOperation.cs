using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class AttributeOperation : AuditableEntity
    {
        public int Id { get; set; }
        public string OperationAsString { get; set; } = null!;
    }
}
