using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.OpenAdvancedFormForAdd
{
    public class OpenAdvancedFormForAddCommand : IRequest<BaseResponse<object>>
    {
        public int VirtualTableForSectionId { get; set; }
        public string? lang { get; set; }
    }
}
