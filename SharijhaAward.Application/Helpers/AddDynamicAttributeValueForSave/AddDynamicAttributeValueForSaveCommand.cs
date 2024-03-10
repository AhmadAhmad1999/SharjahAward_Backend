using MediatR;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeValueForSave
{
    public class AddDynamicAttributeValueForSaveCommand : IRequest<BaseResponse<AddDynamicAttributeValueForSaveResponse>>
    {
        public int RecordId { get; set; }
        public List<AddDynamicAttributeValueForSaveMainCommand> DynamicAttributesWithValues { get; set; } = new List<AddDynamicAttributeValueForSaveMainCommand>();
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
