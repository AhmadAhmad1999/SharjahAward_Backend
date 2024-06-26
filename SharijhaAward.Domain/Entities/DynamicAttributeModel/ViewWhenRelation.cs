using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class ViewWhenRelation : AuditableEntity
    {
        public int Id { get; set; }
        public int? DynamicAttributeId { get; set; }
        public DynamicAttribute? DynamicAttribute { get; set; }
        public int? DynamicAttributeSectionId { get; set; }
        public DynamicAttributeSection? DynamicAttributeSection { get; set; }
        public int DynamicAttributeListValueId { get; set; }
        public DynamicAttributeListValue? DynamicAttributeListValue { get; set; }
    }
}
