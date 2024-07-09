namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntitiesForAdminDashboard
{
    public class GetAllEducationalEntitiesForAdminDashboardListVM
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public List<EducationalInstitutionListVM> EducationalInstitutions { get; set; } = new List<EducationalInstitutionListVM>();
      
    }
}
