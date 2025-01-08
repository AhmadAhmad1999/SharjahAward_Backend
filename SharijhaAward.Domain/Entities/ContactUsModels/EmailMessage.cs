using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.ContactUsConstants;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.ContactUsModels
{
    public class EmailMessage : AuditableEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber {  get; set; }
        public string From { get; set; } = string.Empty;
        public string? To { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        
        public MessageStatus? Status { get; set; } = MessageStatus.New;
        public bool IsRead { get; set; } = false;
        public int? AsignId { get; set; }

        public EmailMessage message { get; set; } = null!;
        [ForeignKey(nameof(message))]
        public int? MessageId { get; set; }

        public User User { get; set; } = null!;
        [ForeignKey(nameof(User))]
        public int ? UserId { get; set; }

        public MessageType Type { get; set; } = null!;
        [ForeignKey(nameof(Type))]
        public int TypeId {  get; set; }

        //public List<EmailAttachment>? Attachments { get; set; } 


    }
}
