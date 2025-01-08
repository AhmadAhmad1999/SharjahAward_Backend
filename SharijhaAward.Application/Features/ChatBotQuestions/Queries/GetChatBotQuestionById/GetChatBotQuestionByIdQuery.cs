using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetChatBotQuestionById
{
    public class GetChatBotQuestionByIdQuery : IRequest<BaseResponse<ChatBotQuestionDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
