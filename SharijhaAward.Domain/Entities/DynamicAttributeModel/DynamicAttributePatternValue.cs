using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class DynamicAttributePatternValue : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicValue { get; set; } = null!;
        public string EnglishValue { get; set; } = null!;
        public int DynamicAttributePatternId { get; set; }
        public DynamicAttributePattern? DynamicAttributePattern { get; set; }
    }
}
