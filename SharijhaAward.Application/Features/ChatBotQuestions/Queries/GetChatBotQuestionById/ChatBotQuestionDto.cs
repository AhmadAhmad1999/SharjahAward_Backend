using SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetAllChatBotQuestions;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetChatBotQuestionById
{
    public class ChatBotQuestionDto
    {
        public int Id { get; set; }
        public string EnglishQuestion { get; set; } = string.Empty;
        public string ArabicQuestion { get; set; } = string.Empty;
        public string EnglishAnswer { get; set; } = string.Empty;
        public string ArabicAnswer { get; set; } = string.Empty;
        public bool Initial { get; set; }
        public List<WorkflowQuestionDto>? WorkflowQuestions { get; set; } = new List<WorkflowQuestionDto>();
    }
}
