namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutionsByCategoryId
{
    public class GetAllEducationalInstitutionsByCategoryIdListVM
    {
        public int Id { get; set; }
        public int DynamicAttributeListValueId { get; set; }
        public string EducationalInstitutionName { get; set; } = null!;
        public string EducationalEntityName { get; set; } = null!;
    }
}
