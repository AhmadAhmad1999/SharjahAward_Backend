using SharijhaAward.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

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
