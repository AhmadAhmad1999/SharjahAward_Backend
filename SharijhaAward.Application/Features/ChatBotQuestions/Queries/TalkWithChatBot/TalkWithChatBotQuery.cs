using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.TalkWithChatBot
{
    public class TalkWithChatBotQuery : IRequest<BaseResponse<ConversationDto>>
    {
        public int QuestionId { get; set; }
        public string? lang { get; set; }
    }
}
