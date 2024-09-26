using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ChatBotModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Commands.CreateChatBotQuestion
{
    public class CreateChatBotQuestionCommand : IRequest<BaseResponse<object>>
    {
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public bool Initial { get; set; }
        public List<int>? WorkflowQuestionIds { get; set; } = null!;
    }
}
