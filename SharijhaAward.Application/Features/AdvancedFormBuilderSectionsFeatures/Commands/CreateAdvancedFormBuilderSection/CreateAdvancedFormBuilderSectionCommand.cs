using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.CreateAdvancedFormBuilderSection
{
    public class CreateAdvancedFormBuilderSectionCommand : IRequest<BaseResponse<object>>
    {
        // [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = null!;
        // [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = null!;
        public int VirtualTableForSectionId { get; set; }
        public bool TableTypeSection { get; set; }
        public string? lang { get; set; }
    }
}
