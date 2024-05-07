namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class EduInstitutionCoordinatorDto
    {
        public int Id { get; set; }
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int EducationalEntityId { get; set; }
    }
}
