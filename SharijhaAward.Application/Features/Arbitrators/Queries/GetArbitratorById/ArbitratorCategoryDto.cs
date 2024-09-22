using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById
{
    public class ArbitratorCategoryDto
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string CategoryName { get; set; } = null!;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        public bool RelatedToClasses { get; set; }
        public List<CategoryClassesDto> Classes { get; set; } = new List<CategoryClassesDto>();
    }
}
