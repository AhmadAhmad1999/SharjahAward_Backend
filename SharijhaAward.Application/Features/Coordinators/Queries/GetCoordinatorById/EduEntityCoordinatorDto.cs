using SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutions;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class EduEntityCoordinatorDto
    {
        public int Id { get; set; }
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int EducationalEntityId { get; set; }
        public List<EducationalInstitutionListVM>? EducationalInstitutions { get; set; }
    }
}
