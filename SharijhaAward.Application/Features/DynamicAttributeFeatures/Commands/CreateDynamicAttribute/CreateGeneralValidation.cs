using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute
{
    public class CreateGeneralValidation
    {
        public int AttributeOperationId { get; set; }
        public string? Value { get; set; }
        
        // DynamicAttributeId Attribute MUST BE Added From DataBase..
    }
}
