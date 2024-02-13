using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Commands.CreateFAQ
{
    public class CreateFAQCommand : IRequest<Unit>
    {
        public string ArabicQuestion { get; set; } = string.Empty;
        public string EnglishQuestion { get; set; } = string.Empty;
        public string ArabicAnswer { get; set; } = string.Empty;
        public string EnglishAnswer { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
    }
}
