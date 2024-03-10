using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Helpers.RejectDynamicAttributeValue
{
    public class RejectDynamicAttributeValueCommand : IRequest<BaseResponse<object>>
    {
        public List<int> DynamicAttributesIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
