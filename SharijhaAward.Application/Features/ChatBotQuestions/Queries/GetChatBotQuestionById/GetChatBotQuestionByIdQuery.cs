using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetChatBotQuestionById
{
    public class GetChatBotQuestionByIdQuery : IRequest<BaseResponse<ChatBotQuestionDto>>
    {
        public int Id { get; set; }
    }
}
