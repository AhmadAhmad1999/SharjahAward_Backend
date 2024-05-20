using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Helpers.RejectDynamicAttributeValue
{
    public class RejectDynamicAttributeValueMainCommand : IRequest<BaseResponse<object>>
    {
        public List<RejectDynamicAttributeValueCommand> RejectDynamicAttributeValueCommand { get; set; } = new List<RejectDynamicAttributeValueCommand>();
        public string? lang { get; set; }
    }
}
