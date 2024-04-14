using SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntitiesForAdminDashboard;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetEducationalEntityById
{
    public class GetEducationalEntityByIdDto
    {
        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public List<EducationalInstitutionListVM> EducationalInstitutions { get; set; } = new List<EducationalInstitutionListVM>();
    }
}
