using MediatR;
using SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetAllChatBotQuestions;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetInitalQuestions
{
    public class GetInitialQuestionsQuery : IRequest<BaseResponse<List<InitialQuestionDto>>>
    {
        public string? lang { get; set; }
    }
}
