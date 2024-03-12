using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel
{
    public class ConditionsProvidedForms : AuditableEntity
    {
        public Guid Id { get; set; }
        public bool IsAgree { get; set; } = false;
        public List<ConditionAttachment> Attachments { get; set; } = null!;

        public TermAndCondition TermAndCondition { get; set; } = null!;
        [ForeignKey(nameof(TermAndCondition))]
        public Guid TermAndConditionId { get; set; }

        public ProvidedForm ProvidedForm { get; set; } = null!;
        [ForeignKey(nameof(ProvidedForm))]
        public int ProvidedFormId { get; set; }
    }
}
