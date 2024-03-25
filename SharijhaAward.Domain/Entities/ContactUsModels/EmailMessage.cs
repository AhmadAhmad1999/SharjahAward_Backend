using Aspose.Pdf.Plugins;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.ContactUsConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ContactUsModels
{
    public class EmailMessage : AuditableEntity
    {
        public Guid Id { get; set; }
        public string From { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public MessageType Type { get; set; }
        public MessageStatus? Status { get; set; } = MessageStatus.New;
        public bool IsRead { get; set; } = false;

        public EmailMessage message { get; set; } = null!;
        [ForeignKey(nameof(message))]
        public Guid? MessageId { get; set; }

        public List<EmailAttachment>? Attachments { get; set; } 
    }
}
