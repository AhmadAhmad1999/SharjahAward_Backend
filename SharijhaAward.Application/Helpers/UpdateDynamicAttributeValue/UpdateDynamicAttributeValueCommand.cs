using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Helpers.UpdateDynamicAttributeValue
{
    public class UpdateDynamicAttributeValueCommand : IRequest<BaseResponse<UpdateDynamicAttributeValueResponse>>
    {
        public int RecordId { get; set; }
        public List<UpdateDynamicAttributeValueMainCommand> DynamicAttributesWithValues { get; set; } = new List<UpdateDynamicAttributeValueMainCommand>();
        public string? lang { get; set; }
    }
}
