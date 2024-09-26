using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ChatBotModel
{
    public class WorkflowQuestion : AuditableEntity
    {
        public int Id { get; set; }
        public ChatBotQuestion Question { get; set; } = null!;
        public int QuestionId { get; set; }
        public ChatBotQuestion Workflow { get; set; } = null!;
        public int WorkflowId { get; set; }
    }
}
