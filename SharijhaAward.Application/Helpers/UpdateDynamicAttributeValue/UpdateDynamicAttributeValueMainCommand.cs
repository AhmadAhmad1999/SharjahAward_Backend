using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Helpers.UpdateDynamicAttributeValue
{
    public class UpdateDynamicAttributeValueMainCommand
    {
        public int DynamicAttributeId { get; set; }
        public string? Value { get; set; } = null!;
    }
}
