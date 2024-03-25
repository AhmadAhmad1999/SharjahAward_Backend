using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage
{
    public class GetAllEmailMessageQuery : IRequest<BaseResponse<List<EmailMessageListVM>>>
    {
        public string token { get; set; } = string.Empty;
        public string lang { get; set; } = string.Empty;
    }
}
