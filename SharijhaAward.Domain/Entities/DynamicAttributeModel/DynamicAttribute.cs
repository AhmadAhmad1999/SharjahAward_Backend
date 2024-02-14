using SharijhaAward.Domain.Constants.DynamicAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class DynamicAttribute
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string ArabicLabel { get; set; } = null!;
        public string EnglishLabel { get; set; } = null!;
        public string ArabicPlaceHolder { get; set; } = null!;
        public string EnglishPlaceHolder { get; set; } = null!;
        public bool IsRequired { get; set; } = false;
        public bool IsUnique { get; set; } = false;
        public bool LinkedToAnotherAttribute { get; set; } = false;
        public DynamicAttributeStatus Status { get; set; } = DynamicAttributeStatus.Inactive;
        public int AttributeDataTypeId { get; set; }
        public AttributeDataType? AttributeDataType { get; set; }
        public int DynamicAttributeSectionId { get; set; }
        public DynamicAttributeSection? DynamicAttributeSection { get; set; }
    }
}
