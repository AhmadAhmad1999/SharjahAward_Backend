using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.AdvancedFormBuilderModel
{
    public class AdvancedFormBuilderViewWhenRelation : AuditableEntity
    {
        public int Id { get; set; }
        public int? AdvancedFormBuilderId { get; set; }
        public AdvancedFormBuilder? AdvancedFormBuilder { get; set; }
        public int? AdvancedFormBuilderSectionId { get; set; }
        public AdvancedFormBuilderSection? AdvancedFormBuilderSection { get; set; }
        public int AdvancedFormBuilderListValueId { get; set; }
        public AdvancedFormBuilderListValue? AdvancedFormBuilderListValue { get; set; }
    }
}
