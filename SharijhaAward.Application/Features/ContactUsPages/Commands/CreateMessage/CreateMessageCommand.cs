using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.ContactUsConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Commands.CreateMessage
{
    public class CreateMessageCommand : IRequest<BaseResponse<int>>
    {
        public string From { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public MessageType Type { get; set; }
        public MessageStatus? Status { get; set; } = MessageStatus.New;
        public int? MessageId { get; set; }
    }
}
