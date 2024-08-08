using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllAdvancedFormBuildersBySectionId;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAdvancedFormBuilderSectionById
{
    public class GetAdvancedFormBuilderSectionByIdDto
    {
        public int Id { get; set; }
        [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = null!;
        public bool TableTypeSection { get; set; }
        public List<AdvancedFormBuilderListVM> AdvancedFormBuilders { get; set; } = new List<AdvancedFormBuilderListVM>();
    }
}
