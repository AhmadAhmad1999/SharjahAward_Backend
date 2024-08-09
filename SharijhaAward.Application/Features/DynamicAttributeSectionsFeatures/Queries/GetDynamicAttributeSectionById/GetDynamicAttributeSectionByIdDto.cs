using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetDynamicAttributeSectionById
{
    public class GetDynamicAttributeSectionByIdDto
    {
        public int Id { get; set; }
        // [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = null!;
        // [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = null!;
        public bool TableTypeSection { get; set; }
        public List<DynamicAttributeListVM> DynamicAttributes { get; set; } = new List<DynamicAttributeListVM>();
    }
}
