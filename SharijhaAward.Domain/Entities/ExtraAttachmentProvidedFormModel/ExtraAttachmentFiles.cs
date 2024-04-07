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
    public class ExtraAttachmentFiles : AuditableEntity
    {
        public Guid Id {  get; set; }
        public string FileUrl { get; set; } = string.Empty;

        public ExtraAttachment? ExtraAttachment { get; set; }
        [ForeignKey(nameof(ExtraAttachment))]
        public Guid ExtraAttachmentId { get; set; }

    }
}
