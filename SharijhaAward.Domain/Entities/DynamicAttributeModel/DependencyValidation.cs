using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class DependencyValidation
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int DependencyGroupId { get; set; }
        public DependencyGroup? DependencyGroup { get; set; }
        public int AttributeOperationId { get; set; }
        public AttributeOperation? AttributeOperation { get; set; }
    }
}
