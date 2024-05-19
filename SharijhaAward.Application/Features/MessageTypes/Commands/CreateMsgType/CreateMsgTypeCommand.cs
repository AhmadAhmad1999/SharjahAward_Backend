using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.MessageTypes.Commands.CreateMsgType
{
    public class CreateMsgTypeCommand : IRequest<BaseResponse<int>>
    {
        public string EnglishType { get; set; } = string.Empty;
        public string ArabicType { get; set; } = string.Empty;
        public string lang { get; set; } = string.Empty;
    }
}
