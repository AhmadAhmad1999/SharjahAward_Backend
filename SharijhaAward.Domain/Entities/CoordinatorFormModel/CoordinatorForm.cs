using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.CoordinatorFormModel
{
    public class CoordinatorForm : AuditableEntity
    {
        public int Id { get; set; }

        public ProvidedForm ProvidedForm { get; set; } = null!;
        [ForeignKey(nameof(ProvidedForm))]
        public int ProvidedFormId { get; set; }

        public Coordinator Coordinator { get; set; } = null!;
        [ForeignKey(nameof(Coordinator))]
        public int CoordinatorId { get; set; }
    }
}
