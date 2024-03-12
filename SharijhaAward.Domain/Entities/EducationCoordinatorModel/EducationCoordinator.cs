using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.EducationCoordinatorModel
{
    public class EducationCoordinator : AuditableEntity
    {
        public Guid Id { get; set; }

        public DateTime RelatedDate { get; set; }

        public Coordinator Coordinator { get; set; } = null!;
        [ForeignKey(nameof(Coordinator))]
        public Guid CoordinatorId {  get; set; }

        public EducationalEntity EducationalEntity { get; set; } = null!;
        [ForeignKey(nameof(EducationalEntity))]
        public Guid EducationalEntityId { get; set; }
    }
}
