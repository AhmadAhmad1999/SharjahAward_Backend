using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.UpdateDynamicAttributeListValue
{
    public class UpdateDynamicAttributeListValueCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public string? lang { get; set; }
    }
}
