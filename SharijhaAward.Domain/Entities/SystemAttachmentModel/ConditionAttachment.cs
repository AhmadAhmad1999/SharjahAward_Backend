using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.AttachmentModel
{
    public class ConditionAttachment : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string AttachementPath { get; set; } = string.Empty;
        public int SizeOfAttachmentInKB { get; set; }
        public bool? IsAccept { get; set; }
        public string? ReasonOfReject { get; set; }

        public ConditionsProvidedForms ConditionsProvidedForms { get; set; } = null!;
       
        [ForeignKey(nameof(ConditionsProvidedForms))]
        public int? ConditionsProvidedFormsId {  get; set; }

    }
}
