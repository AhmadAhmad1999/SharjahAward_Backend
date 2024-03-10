using MediatR;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Helpers.UpdateDynamicAttributeValue
{
    public class UpdateDynamicAttributeValueCommand : IRequest<BaseResponse<UpdateDynamicAttributeValueResponse>>
    {
        public Guid RecordId { get; set; }
        public List<UpdateDynamicAttributeValueMainCommand> DynamicAttributesWithValues { get; set; } = new List<UpdateDynamicAttributeValueMainCommand>();
        public string? lang { get; set; }
    }
}
