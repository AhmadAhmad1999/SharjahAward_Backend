using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModels
{
    public class StaticAttribute
    {
        public int Id { get; set; }
        public string Key { get; set; } = string.Empty;

        public DynamicAttributeDataType DataType { get; set; } = null!;
        [ForeignKey(nameof(DataType))]
        public int DataTypeId { get; set; }

        public DynamicAttributeTableName TableName { get; set; } = null!;
        [ForeignKey(nameof(TableName))]
        public int TableNameId { get; set; }

    }
}
