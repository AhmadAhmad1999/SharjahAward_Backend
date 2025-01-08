using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetAllChatBotQuestions
{
    public class GetAllChatBotQuestionsQuery : IRequest<BaseResponse<List<ChatBotQuestionsListVM>>>
    {
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? lang { get; set; }
    }
}
