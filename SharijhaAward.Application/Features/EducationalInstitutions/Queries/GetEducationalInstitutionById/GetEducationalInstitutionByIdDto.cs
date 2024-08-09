using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetEducationalInstitutionById
{
    public class GetEducationalInstitutionByIdDto
    {
        public int Id { get; set; }
        // [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = null!;
        // [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = null!;
        public EducationType EducationType { get; set; }
        public Emirates Emirates { get; set; }
    }
}
