using SharijhaAward.Domain.Constants.ContactUsConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage
{
    public class EmailMessageListVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string From { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public MessageType Type { get; set; }
        public MessageStatus? Status { get; set; } = MessageStatus.New;
        public Guid? MessageId { get; set; }
        public bool IsReplay { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
