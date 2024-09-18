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
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? lang { get; set; }
    }
}
