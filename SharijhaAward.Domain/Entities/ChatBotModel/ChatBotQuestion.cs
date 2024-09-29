using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ChatBotModel
{
    public class ChatBotQuestion : AuditableEntity
    {
        public int Id { get; set; }
        public string EnglishQuestion { get; set; } = string.Empty;
        public string ArabicQuestion { get; set; } = string.Empty;
        public string EnglishAnswer { get; set; } = string.Empty;
        public string ArabicAnswer { get; set; } = string.Empty;

        public bool Initial { get; set; }

    }
}
