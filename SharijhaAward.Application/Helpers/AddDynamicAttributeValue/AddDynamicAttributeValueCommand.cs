using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeValue
{
    public class AddDynamicAttributeValueCommand : IRequest<BaseResponse<AddDynamicAttributeValueResponse>>
    {
        public int RecordId { get; set; }
        public List<AddDynamicAttributeValueMainCommand> DynamicAttributesWithValues { get; set; } = new List<AddDynamicAttributeValueMainCommand>();
        public List<AddDynamicAttributeTableValueMainCommand> DynamicAttributesWithTableValues { get; set; } = new List<AddDynamicAttributeTableValueMainCommand>();
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
