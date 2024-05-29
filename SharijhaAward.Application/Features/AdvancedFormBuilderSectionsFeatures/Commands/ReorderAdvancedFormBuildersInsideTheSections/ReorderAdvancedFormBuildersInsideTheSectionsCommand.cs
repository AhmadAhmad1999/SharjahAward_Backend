using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.ReorderAdvancedFormBuildersInsideTheSections
{
    public class ReorderAdvancedFormBuildersInsideTheSectionsCommand : IRequest<BaseResponse<object>>
    {
        public List<AdvancedFormBuilderSectionDto> AdvancedFormBuilderSectionDto { get; set; } = new List<AdvancedFormBuilderSectionDto>();
        public string? lang { get; set; }
    }
}
