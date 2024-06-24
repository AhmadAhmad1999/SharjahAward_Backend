using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Entities.CircularModel;
using SharijhaAward.Domain.Entities.CoordinatorFormModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;

namespace SharijhaAward.Domain.Entities.CoordinatorModel
{
    public class Coordinator : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        public List<EduEntitiesCoordinator>? EducationCoordinators { get; set; } 
        public List<EduInstitutionCoordinator>? InstitutionCoordinators {  get; set; }
        public List<CoordinatorForm> CoordinatorForms { get; set; } = null!;
        public List<CircularCoordinator>? CircularCoordinators { get; set; }
    }
}
