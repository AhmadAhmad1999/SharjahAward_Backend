using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel
{
    public class ExtraAttachmentFile : AuditableEntity
    {
        public int Id {  get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FileDescription { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
        public bool? IsAccept {  get; set; }
        public string? ReasonOfReject { get; set; }

        public ExtraAttachment? ExtraAttachment { get; set; }
        [ForeignKey(nameof(ExtraAttachment))]
        public int ExtraAttachmentId { get; set; }

    }
}
