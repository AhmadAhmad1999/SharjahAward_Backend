using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class DynamicAttributeValue : AuditableEntity
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int? RecordId { get; set; }
        public int? RecordIdAsGuid { get; set; }
        public bool isAccepted { get; set; }
        public int DynamicAttributeId { get; set; }
        public DynamicAttribute? DynamicAttribute { get; set; }
    }
}
