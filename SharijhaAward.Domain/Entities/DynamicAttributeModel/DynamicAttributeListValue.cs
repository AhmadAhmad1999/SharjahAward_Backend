using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class DynamicAttributeListValue
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int DynamicAttributeId { get; set; }
        public DynamicAttribute? DynamicAttribute { get; set; }
    }
}
