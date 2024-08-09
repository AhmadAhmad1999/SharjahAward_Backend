using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.UpdateDynamicAttributeSection
{
    public class UpdateDynamicAttributeSectionCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        // [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = null!;
        // [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = null!;
        public int? MinNumberOfRows { get; set; }
        public int? MaxNumberOfRows { get; set; }
        public string? lang { get; set; }
    }
}
