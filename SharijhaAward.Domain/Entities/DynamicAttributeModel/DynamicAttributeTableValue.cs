using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class DynamicAttributeTableValue : AuditableEntity
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int RowId { get; set; }
        public int RecordId { get; set; }
        public bool? isAccepted { get; set; }
        public string? ReasonForRejecting { get; set; }
        public int DynamicAttributeId { get; set; }
        public DynamicAttribute? DynamicAttribute { get; set; }
    }
}
