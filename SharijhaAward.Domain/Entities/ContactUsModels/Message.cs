using Aspose.Pdf.Plugins;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.ContactUsConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ContactUsModels
{
    public class Message : AuditableEntity
    {
        public Guid Id { get; set; }
        public string From { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public MessageType Type { get; set; }
        public MessageStatus? Status { get; set; } = MessageStatus.New;

        public List<EmailAttachment>? Attachments { get; set; } 
    }
}
