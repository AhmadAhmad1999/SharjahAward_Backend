using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ContactUsModels
{
    public class MessageType : AuditableEntity
    {
        public int Id { get; set; }
        public string EnglishType { get; set; } = string.Empty;
        public string ArabicType { get; set; } = string.Empty;
        public List<EmailMessage> EmailMessages { get; set; } = null!;
    }
}
