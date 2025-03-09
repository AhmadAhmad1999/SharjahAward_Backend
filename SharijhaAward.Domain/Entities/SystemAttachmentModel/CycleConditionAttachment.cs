using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.SystemAttachmentModel
{
    public class CycleConditionAttachment : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string AttachementPath { get; set; } = string.Empty;
        public int SizeOfAttachmentInKB { get; set; }
        public bool? IsAccept { get; set; } 
        public string? ReasonOfReject { get; set; }
        public CycleConditionsProvidedForm CycleConditionsProvidedForm { get; set; } = null!;

        [ForeignKey(nameof(CycleConditionsProvidedForm))]
        public int? CycleConditionsProvidedFormId { get; set; }
    }
}
