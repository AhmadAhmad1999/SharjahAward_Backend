﻿using SharijhaAward.Domain.Constants.ContactUsConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage
{
    public class EmailMessageListVM
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string From { get; set; } = string.Empty;
        public string? To { get; set; } = string.Empty;
        public MessageType Type { get; set; }
        public MessageStatus? Status { get; set; } = MessageStatus.New;
        public int? MessageId { get; set; }
        public bool IsReplay { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<EmailAttachmentListVm> Attachments { get; set; } = null!;

    }
}
