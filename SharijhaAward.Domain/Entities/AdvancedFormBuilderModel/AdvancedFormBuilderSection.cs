using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.AdvancedFormBuilderModel
{
    public class AdvancedFormBuilderSection : AuditableEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public bool TableTypeSection { get; set; }
        public int VirtualTableForSectioniD { get; set; }
        public VirtualTableForSection? VirtualTableForSection { get; set; }
    }
}
