using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderListValues.Commands.UpdateAdvancedFormBuilderListValue
{
    public class UpdateAdvancedFormBuilderListValueCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public string? lang { get; set; }
    }
}
