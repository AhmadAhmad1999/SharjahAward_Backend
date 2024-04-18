using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.ForwordEmail
{
    public class ForwordEmailQuery : IRequest<BaseResponse<object>>
    {
        public int MsgId { get; set; }
        public string token { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public string lang { get; set; } = string.Empty;
    }
}
