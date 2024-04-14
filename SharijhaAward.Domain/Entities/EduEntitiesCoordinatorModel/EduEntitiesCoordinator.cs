using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;

namespace SharijhaAward.Domain.Entities.EducationCoordinatorModel
{
    public class EduEntitiesCoordinator : AuditableEntity
    {
        public int Id { get; set; }
        public DateTime RelatedDate { get; set; }
        public int CoordinatorId { get; set; }
        public Coordinator? Coordinator { get; set; }
        public int EducationalEntityId { get; set; }
        public EducationalEntity? EducationalEntity { get; set; }
    }
}
