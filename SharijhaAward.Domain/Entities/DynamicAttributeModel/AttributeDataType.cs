using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class AttributeDataType : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
    }
}
