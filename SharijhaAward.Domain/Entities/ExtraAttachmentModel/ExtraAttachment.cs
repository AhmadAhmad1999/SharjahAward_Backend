using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ExtraAttachmentModel
{
    public class ExtraAttachment : AuditableEntity
    {
        public Guid Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set;} = string.Empty;
        public int RequiredAttachmentNumber { get; set; }
        public AttachmentType AttachmentType { get; set; }
        public int SizeOfAttachmentInKB { get; set; }

        public List<ExtraAttachmentProvidedForm>? ExtraAttachmentProvidedForms { get; set; }
    }
}
