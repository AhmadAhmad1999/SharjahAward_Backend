using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotFeature.Queries.TalkWithChatBot
{
    public class TalkWithChatBotQuery : IRequest<BaseResponse<string>>
    {
        public string message { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
