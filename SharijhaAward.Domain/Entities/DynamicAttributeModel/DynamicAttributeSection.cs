using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class DynamicAttributeSection : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public Guid? RecordIdOnRelation { get; set; }
        public int AttributeTableNameId { get; set; }
        public AttributeTableName? AttributeTableName { get; set; }
    }
}
