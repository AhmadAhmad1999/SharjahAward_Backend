using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Queries.GetFAQById
{
    public class FAQDto
    {
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public string ArabicQuestion { get; set; } = string.Empty;
        public string EnglishQuestion { get; set; } = string.Empty;
        public string ArabicAnswer { get; set; } = string.Empty;
        public string EnglishAnswer { get; set; } = string.Empty;
    }
}
