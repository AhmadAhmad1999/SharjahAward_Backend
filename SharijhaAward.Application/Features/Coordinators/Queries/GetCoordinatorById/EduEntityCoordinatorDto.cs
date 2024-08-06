using SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutions;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class EduEntityCoordinatorDto
    {
        public int Id { get; set; }
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int EducationalEntityId { get; set; }
        public List<EducationalInstitutionListVM>? EducationalInstitutions { get; set; }
    }
}
