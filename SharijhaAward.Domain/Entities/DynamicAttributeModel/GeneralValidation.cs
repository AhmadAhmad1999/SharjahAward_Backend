using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class GeneralValidation : AuditableEntity
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int DynamicAttributeId { get; set; }
        public DynamicAttribute? DynamicAttribute { get; set; }
        public int AttributeOperationId { get; set; }
        public AttributeOperation? AttributeOperation { get; set; }
    }
}
