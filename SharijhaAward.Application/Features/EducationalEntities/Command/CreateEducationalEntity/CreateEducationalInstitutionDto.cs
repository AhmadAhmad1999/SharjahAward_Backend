using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;

namespace SharijhaAward.Application.Features.EducationalEntities.Command.CreateEducationalEntity
{
    public class CreateEducationalInstitutionDto
    {
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
    }
}
