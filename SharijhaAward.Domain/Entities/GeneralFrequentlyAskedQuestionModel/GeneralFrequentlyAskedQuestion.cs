using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel
{
    public class GeneralFrequentlyAskedQuestion : AuditableEntity
    {
        public Guid Id { get; set; }
        public string ArabicQuestion { get; set; } = null!;
        public string EnglishQuestion { get; set; } = null!;
        public string ArabicAnswer { get; set; } = null!;
        public string EnglishAnswer { get; set; } = null!;
    }
}
