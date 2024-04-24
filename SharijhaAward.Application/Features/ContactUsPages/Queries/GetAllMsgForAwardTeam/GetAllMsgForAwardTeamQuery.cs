using MediatR;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllMsgForAwardTeam
{
    public class GetAllMsgForAwardTeamQuery : IRequest<BaseResponse<List<EmailMessageListVM>>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public string token { get; set; } = string.Empty;

    }
}
