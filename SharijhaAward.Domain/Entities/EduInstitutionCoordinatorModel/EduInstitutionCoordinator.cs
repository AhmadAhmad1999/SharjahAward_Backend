using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel
{
    public class EduInstitutionCoordinator : AuditableEntity
    {
        public Guid Id { get; set; }

        public Coordinator Coordinator { get; set; } = null!;
        [ForeignKey(nameof(Coordinator))]
        public Guid CoordinatorId { get; set; }

        public EducationalInstitution EducationalInstitution { get; set; } = null!;
        [ForeignKey(nameof(EducationalInstitution))]
        public Guid EducationalInstitutionId { get; set; }
    }
}
