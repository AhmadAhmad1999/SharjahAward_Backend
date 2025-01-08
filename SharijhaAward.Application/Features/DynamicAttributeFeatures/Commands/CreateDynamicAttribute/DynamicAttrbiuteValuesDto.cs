using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute
{
    public class DynamicAttrbiuteValuesDto
    {
        [ArabicNameValidation]
        public string ArabicValue { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishValue { get; set; } = null!;
    }
}
