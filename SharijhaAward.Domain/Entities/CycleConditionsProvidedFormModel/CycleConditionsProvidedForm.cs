using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel
{
    public class CycleConditionsProvidedForm : AuditableEntity
    {
        public int Id { get; set; }
        public bool IsAgree { get; set; } = false;
        //public List<CycleConditionAttachment> Attachments { get; set; } = null!;

        public CycleCondition CycleCondition { get; set; } = null!;
        [ForeignKey(nameof(CycleCondition))]
        public int CycleConditionId { get; set; }

        public ProvidedForm ProvidedForm { get; set; } = null!;
        [ForeignKey(nameof(ProvidedForm))]
        public int ProvidedFormId { get; set; }
    }
}
