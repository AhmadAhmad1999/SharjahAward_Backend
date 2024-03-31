namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntitiesForAdminDashboard
{
    public class GetAllEducationalEntitiesForAdminDashboardListVM
    {
        public Guid Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public List<EducationalInstitutionListVM> EducationalInstitutions { get; set; } = new List<EducationalInstitutionListVM>();
        public List<EducaltionalEntitiesCoordinatorListVM> Coordinators { get; set; } = new List<EducaltionalEntitiesCoordinatorListVM>();
    }
}
