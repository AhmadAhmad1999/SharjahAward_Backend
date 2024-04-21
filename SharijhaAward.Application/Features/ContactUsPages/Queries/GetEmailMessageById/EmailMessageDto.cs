using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Constants.ContactUsConstants;
using SharijhaAward.Domain.Entities.ContactUsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetEmailMessageById
{
    public class EmailMessageDto 
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string From { get; set; } = string.Empty;
        public string? To { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string TypeName { get; set; } = string.Empty;
        public MessageStatus? Status { get; set; } = MessageStatus.New;
        public bool IsRead { get; set; } 
        public int? MessageId { get; set; }
        public bool IsReplay { get; set; }
        public string PersonalPhotoUrl { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<EmailAttachmentListVm> Attachments { get; set; } = null!;
        public List<EmailMessageDto> ReplayMessages { get; set; } = null!;
    }
}
