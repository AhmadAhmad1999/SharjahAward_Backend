using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Commands.UpdateFAQ
{
    public class UpdateFAQCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string ArabicQuestion { get; set; } = string.Empty;
        public string EnglishQuestion { get; set; } = string.Empty;
        public string ArabicAnswer { get; set; } = string.Empty;
        public string EnglishAnswer { get; set; } = string.Empty;
        public string lang { get; set; } = string.Empty;
    }
}
