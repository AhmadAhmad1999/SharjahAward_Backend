namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetEducationalInstitutionById
{
    public class GetEducationalInstitutionByIdDto
    {
        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
    }
}
