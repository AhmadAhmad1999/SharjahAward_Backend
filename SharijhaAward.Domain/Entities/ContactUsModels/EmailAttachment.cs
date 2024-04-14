using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ContactUsModels
{
    public class EmailAttachment : AuditableEntity
    {
        public int Id { get; set; }
        public string AttachmentUrl {  get; set; } = string.Empty;
        public EmailMessage Message { get; set; } = null!;

        [ForeignKey(nameof(Message))]
        public int MessageId { get; set; }
    }
}
