using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Commands.DeleteChatBotQuestion
{
    public class DeleteChatBotQuestionCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
    }
}
