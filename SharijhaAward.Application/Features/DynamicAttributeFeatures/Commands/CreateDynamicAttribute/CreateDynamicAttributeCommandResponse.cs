using SharijhaAward.Application.Features.Event.Commands.CreateEvent;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute
{
    public class CreateDynamicAttributeCommandResponse : BaseResponse<object>
    {
        public CreateDynamicAttributeCommandResponse() : base() { }
        public CreateDynamicAttributeDto CreateDynamicAttributeDto { get; set; }
    }
}
