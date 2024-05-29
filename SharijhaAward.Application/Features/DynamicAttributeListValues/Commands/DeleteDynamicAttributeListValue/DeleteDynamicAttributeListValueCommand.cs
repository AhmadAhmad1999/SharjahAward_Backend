using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.DeleteDynamicAttributeListValue
{
    public class DeleteDynamicAttributeListValueCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}