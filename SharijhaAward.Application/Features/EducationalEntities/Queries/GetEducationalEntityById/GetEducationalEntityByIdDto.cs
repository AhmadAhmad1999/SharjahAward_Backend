using SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntitiesForAdminDashboard;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetEducationalEntityById
{
    public class GetEducationalEntityByIdDto
    {
        public int Id { get; set; }
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
        public List<EducationalInstitutionListVM> EducationalInstitutions { get; set; } = new List<EducationalInstitutionListVM>();
    }
}
