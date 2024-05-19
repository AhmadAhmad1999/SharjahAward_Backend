using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.MessageTypes.Queries.GetAllMsgType
{
    public class GetAllMsgQuery : IRequest<BaseResponse<List<MessageTypeListVM>>>
    {
        public string? lang { get; set; }
    }
}
