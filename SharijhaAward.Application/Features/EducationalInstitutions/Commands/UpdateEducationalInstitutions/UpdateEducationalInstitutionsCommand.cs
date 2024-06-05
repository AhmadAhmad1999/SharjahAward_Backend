using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.UpdateEducationalInstitutions
{
    public class UpdateEducationalInstitutionsCommand
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public EducationType EducationType { get; set; }
        public Emirates Emirates { get; set; }
    }
}
