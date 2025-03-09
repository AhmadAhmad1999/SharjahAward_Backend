using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.ExtraAttachmentModel
{
    public class ExtraAttachment : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set;} = string.Empty;
        public int RequiredAttachmentNumber { get; set; }
        public int SizeOfAttachmentInKB { get; set; }
        public ProvidedForm ProvidedForm { get; set; } = null!;
        [ForeignKey(nameof(ProvidedForm))]
        public int ProvidedFormId {  get; set; }
        public bool isAccepted { get; set; }
    }
}
