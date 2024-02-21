using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class StaticAttribute : AuditableEntity
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string ArabicLabel { get; set; } = null!;
        public string EnglishLabel { get; set; } = null!;
        public int AttributeDataTypeId { get; set; }
        public AttributeDataType? AttributeDataType { get; set; }
        public int AttributeTableNameId { get; set; }
        public AttributeTableName? AttributeTableName { get; set; }
    }
}
