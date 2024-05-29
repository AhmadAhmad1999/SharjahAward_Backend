using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderPatterns.Commands.SelectPatternAsAdvancedFormBuilder
{
    public class SelectPatternAsAdvancedFormBuilderCommand : IRequest<BaseResponse<object>>
    {
        public int AdvancedFormBuilderPatternId { get; set; }
        public int AdvancedFormBuilderSectionId { get; set; }
        public string? lang { get; set; }
    }
}
