using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.CreateDynamicAttributeListValue
{
    public class CreateDynamicAttributeListValueCommand : IRequest<BaseResponse<CreateDynamicAttributeListValueResponse>>
    {
        public string Value { get; set; } = null!;
        public int DynamicAttributeId { get; set; }
        public string? lang { get; set; }
    }
}
