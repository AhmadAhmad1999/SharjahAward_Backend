using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.AdvancedFormBuilderModel
{
    public class AdvancedFormBuilderPatternValue : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicValue { get; set; } = null!;
        public string EnglishValue { get; set; } = null!;
        public int AdvancedFormBuilderPatternId { get; set; }
        public AdvancedFormBuilderPattern? AdvancedFormBuilderPattern { get; set; }
    }
}
