using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;

namespace SharijhaAward.Domain.Entities.EducationalEntityModel
{
    public class EducationalEntity: AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public List<EducationalInstitution> Institutions { get; set; } = null!;
        public List<EduEntitiesCoordinator> eduEntities { get; set; } = null!;
    }
}
