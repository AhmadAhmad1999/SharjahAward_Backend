using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel
{
    public class CycleConditionsProvidedForm : AuditableEntity
    {
        public Guid Id { get; set; }
        public bool IsAgree { get; set; } = false;
        public List<ConditionAttachment> Attachments { get; set; } = null!;

        public CycleCondition CycleCondition { get; set; } = null!;
        [ForeignKey(nameof(CycleCondition))]
        public Guid CycleConditionId { get; set; }

        public ProvidedForm ProvidedForm { get; set; } = null!;
        [ForeignKey(nameof(ProvidedForm))]
        public int ProvidedFormId { get; set; }
    }
}
