using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.MessageTypes.Commands.UpdateMsgType
{
    public class UpdateMsgTypeCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;

        public string lang { get; set; } = string.Empty;

    }
}
