using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.CreateVirtualTableFroSection
{
    public class CreateVirtualTableFroSectionCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string? lang { get; set; }
    }
}
