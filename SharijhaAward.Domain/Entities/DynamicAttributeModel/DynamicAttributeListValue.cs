using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class DynamicAttributeListValue : AuditableEntity
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int DynamicAttributeId { get; set; }
        public DynamicAttribute? DynamicAttribute { get; set; }
    }
}
