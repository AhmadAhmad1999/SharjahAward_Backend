using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.AdvancedFormBuilderModel
{
    public class AdvancedFormBuilderValue : AuditableEntity
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int VirtualTableId { get; set; }
        public VirtualTable? VirtualTable { get; set; }
        public int AdvancedFormBuilderId { get; set; }
        public AdvancedFormBuilder? AdvancedFormBuilder { get; set; }
    }
}
