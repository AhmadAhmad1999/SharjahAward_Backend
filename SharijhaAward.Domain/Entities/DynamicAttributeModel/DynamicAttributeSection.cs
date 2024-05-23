using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class DynamicAttributeSection : AuditableEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public int? RecordIdOnRelation { get; set; }
        public bool TableTypeSection { get; set; }
        public int AttributeTableNameId { get; set; }
        public AttributeTableName? AttributeTableName { get; set; }
    }
}
