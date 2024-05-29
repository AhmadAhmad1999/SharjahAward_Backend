using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderListValues.Commands.CreateAdvancedFormBuilderListValue
{
    public class CreateAdvancedFormBuilderListValueCommand : IRequest<BaseResponse<object>>
    {
        public string Value { get; set; } = null!;
        public int AdvancedFormBuilderId { get; set; }
        public string? lang { get; set; }
    }
}
