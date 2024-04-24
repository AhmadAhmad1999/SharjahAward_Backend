using MediatR;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetEmailMessageById;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetMsgByIdForAwardTeam
{
    public class GetMsgByIdForAwardTeamQuery : IRequest<BaseResponse<EmailMessageDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
        public string token { get; set; } = string.Empty;
    }
}
