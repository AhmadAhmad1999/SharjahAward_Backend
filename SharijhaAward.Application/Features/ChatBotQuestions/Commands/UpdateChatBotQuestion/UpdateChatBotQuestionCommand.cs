using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Commands.UpdateChatBotQuestion
{
    public class UpdateChatBotQuestionCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string EnglishQuestion { get; set; } = string.Empty;
        public string ArabicQuestion { get; set; } = string.Empty;
        public string EnglishAnswer { get; set; } = string.Empty;
        public string ArabicAnswer { get; set; } = string.Empty;
        public bool Initial { get; set; }
        public List<int> WorkflowQuestionIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
