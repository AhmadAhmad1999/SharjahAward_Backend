using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.CreateAdvancedFormBuilderSection
{
    public class CreateAdvancedFormBuilderSectionCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public int VirtualTableForSectionId { get; set; }
        public bool TableTypeSection { get; set; }
        public string? lang { get; set; }
    }
}
