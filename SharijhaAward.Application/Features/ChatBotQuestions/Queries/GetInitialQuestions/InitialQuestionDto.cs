using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetInitalQuestions
{
    public class InitialQuestionDto
    {
        public int Id { get; set; }
        public string Qusetion { get; set; } = string.Empty;
    }
}
