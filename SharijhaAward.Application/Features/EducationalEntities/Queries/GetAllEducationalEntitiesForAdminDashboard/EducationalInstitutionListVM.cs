using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntitiesForAdminDashboard
{
    public class EducationalInstitutionListVM
    {
        public int Id { get; set; }
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
    }
}
