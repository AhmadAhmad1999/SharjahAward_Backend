using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.AdvancedFormBuilderModel
{
    public class VirtualTableForSection : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public bool isOpen { get; set; }
        public string PrivateHashKey { get; set; } = null!;
    }
}
