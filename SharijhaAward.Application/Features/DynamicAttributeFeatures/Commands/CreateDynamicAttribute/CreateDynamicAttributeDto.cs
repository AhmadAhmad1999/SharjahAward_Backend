using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute
{
    public class CreateDynamicAttributeDto
    {
        public int Id { get; set; }
        [EnglishNameValidation]
        public string EnglishLabel { get; set; } = null!;
        [ArabicNameValidation]
        public string ArabicLabel { get; set; } = null!;
    }
}
