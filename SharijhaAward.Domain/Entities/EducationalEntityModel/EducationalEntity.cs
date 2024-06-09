using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;

namespace SharijhaAward.Domain.Entities.EducationalEntityModel
{
    public class EducationalEntity: AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public List<EducationalInstitution> Institutions { get; set; } = null!;
    }
}
