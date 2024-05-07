using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutions
{
    public class EducationalInstitutionListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public EducationType EducationType { get; set; }
        public Emirates Emirates { get; set; }
    }
}
