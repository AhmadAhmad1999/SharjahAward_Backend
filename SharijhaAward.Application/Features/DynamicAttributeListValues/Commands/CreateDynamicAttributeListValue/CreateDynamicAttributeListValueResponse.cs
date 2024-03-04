using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.CreateDynamicAttributeListValue
{
    public class CreateDynamicAttributeListValueResponse : BaseResponse<object>
    {
        public CreateDynamicAttributeListValueResponse() : base() { }
        public CreateDynamicAttributeListValueDto CreateDynamicAttributeListValueDto { get; set; }
    }
}
