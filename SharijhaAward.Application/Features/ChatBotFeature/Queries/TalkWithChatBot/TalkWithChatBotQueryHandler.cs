using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotFeature.Queries.TalkWithChatBot
{
    public class TalkWithChatBotQueryHandler
        : IRequestHandler<TalkWithChatBotQuery, BaseResponse<string>>
    {
        private readonly IChatBotService _chatBotService;

        public TalkWithChatBotQueryHandler(IChatBotService chatBotService)
        {
            _chatBotService = chatBotService;
        }

        public async Task<BaseResponse<string>> Handle(TalkWithChatBotQuery request, CancellationToken cancellationToken)
        {
            var data = _chatBotService.GetResponse(request.message);

            return new BaseResponse<string>("", true, 200, data);
        }
    }
}
