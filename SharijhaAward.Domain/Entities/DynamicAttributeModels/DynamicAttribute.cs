using SharijhaAward.Domain.Constants.DynamicAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModels
{
    public class DynamicAttribute
    {
        public int Id { get; set; }
        public string Key { get; set; }=string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsUnique { get; set; }
        public bool IsRequired { get; set; }

        public DynamicAttributeStatus Status { get; set; }


        public DynamicAttributeDataType DataType { get; set; } = null!;

        [ForeignKey(nameof(DataType))]
        public int DataTypeId { get; set; }

        public DynamicAttributeTableName TableName { get; set; } = null!;
        [ForeignKey(nameof(TableName))]
        public int TableNameId { get; set; }

        public DynamicAttributeSection Section { get; set; } = null!;
        [ForeignKey(nameof(Section))]
        public int SectionId { get; set; }
    }
}
