using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetAllChatBotQuestions
{
    public class ChatBotQuestionsListVM
    {
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public bool Initial { get; set; }
        public List<WorkflowQuestionDto>? WorkflowQuestions { get; set; } = new List<WorkflowQuestionDto>();
    }
}
