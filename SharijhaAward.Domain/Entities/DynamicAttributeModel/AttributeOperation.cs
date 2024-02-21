using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class AttributeOperation : AuditableEntity
    {
        public int Id { get; set; }
        public string OperationAsString { get; set; } = null!;
    }
}
