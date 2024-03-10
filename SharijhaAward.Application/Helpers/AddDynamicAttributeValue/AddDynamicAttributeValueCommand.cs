using MediatR;
using SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.CreateDynamicAttributeListValue;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeValue
{
    public class AddDynamicAttributeValueCommand : IRequest<BaseResponse<AddDynamicAttributeValueResponse>>
    {
        public int RecordId { get; set; }
        public List<AddDynamicAttributeValueMainCommand> DynamicAttributesWithValues { get; set; } = new List<AddDynamicAttributeValueMainCommand>();
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
