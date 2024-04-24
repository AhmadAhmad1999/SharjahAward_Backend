using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.ClosingEmailMessage
{
    public class ClosingEmailMessageQuery : IRequest<BaseResponse<object>>
    {
        public string token { get; set; } = string.Empty;
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
