using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ChatBotModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.TalkWithChatBot
{
    public class TalkWithChatBotQueryHandler
        : IRequestHandler<TalkWithChatBotQuery, BaseResponse<string>>
    {
        private readonly IAsyncRepository<ChatBotQuestion> _chatBotQuestionRepository;
        private readonly IAsyncRepository<WorkflowQuestion> _workflowQuestionRepository;
        private readonly IMapper _mapper;

        public TalkWithChatBotQueryHandler(IAsyncRepository<ChatBotQuestion> chatBotQuestionRepository, IAsyncRepository<WorkflowQuestion> workflowQuestionRepository, IMapper mapper)
        {
            _chatBotQuestionRepository = chatBotQuestionRepository;
            _workflowQuestionRepository = workflowQuestionRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<string>> Handle(TalkWithChatBotQuery request, CancellationToken cancellationToken)
        {
            var data = "";

            return new BaseResponse<string>("", true, 200, data);
        }
    }
}
