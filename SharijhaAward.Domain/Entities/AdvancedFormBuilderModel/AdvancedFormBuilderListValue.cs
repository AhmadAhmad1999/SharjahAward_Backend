using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.AdvancedFormBuilderModel
{
    public class AdvancedFormBuilderListValue : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicValue { get; set; } = null!;
        public string EnglishValue { get; set; } = null!;
        public int AdvancedFormBuilderId { get; set; }
        public AdvancedFormBuilder? AdvancedFormBuilder { get; set; }
    }
}
