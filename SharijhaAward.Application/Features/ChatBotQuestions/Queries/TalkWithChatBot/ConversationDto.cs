using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.TalkWithChatBot
{
    public class ConversationDto
    {
        public int Id { get; set; }
        public string Answer { get; set; } = string.Empty;
        public List<ConversationWorkflowListVM>? Workflow { get; set; }
    }
}
