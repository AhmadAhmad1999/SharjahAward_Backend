using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.DynamicAttribute;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class DynamicAttribute : AuditableEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string ArabicLabel { get; set; } = null!;
        public string EnglishLabel { get; set; } = null!;
        public string ArabicPlaceHolder { get; set; } = null!;
        public string EnglishPlaceHolder { get; set; } = null!;
        public bool IsRequired { get; set; } = false;
        public bool IsUnique { get; set; } = false;
        public bool LinkedToAnotherAttribute { get; set; } = false;
        public DynamicAttributeStatus Status { get; set; } = DynamicAttributeStatus.Inactive;
        public int? MaxSizeInKB { get; set; }
        public int AttributeDataTypeId { get; set; }
        public AttributeDataType? AttributeDataType { get; set; }
        public int DynamicAttributeSectionId { get; set; }
        public DynamicAttributeSection? DynamicAttributeSection { get; set; }
    }
}
