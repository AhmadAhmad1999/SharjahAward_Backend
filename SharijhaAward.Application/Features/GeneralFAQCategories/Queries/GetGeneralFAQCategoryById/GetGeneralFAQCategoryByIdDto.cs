
using SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetAllGeneralFAQCategory;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetGeneralFAQCategoryById
{
    public class GetGeneralFAQCategoryByIdDto
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        public List<GetAllGeneralFAQListVM> GeneralFAQListVM { get; set; } = new List<GetAllGeneralFAQListVM>();
    }
}
