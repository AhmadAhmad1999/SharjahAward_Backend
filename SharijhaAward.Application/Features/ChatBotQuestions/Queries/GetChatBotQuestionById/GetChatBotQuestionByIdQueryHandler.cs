using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetAllChatBotQuestions;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ChatBotModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetChatBotQuestionById
{
    public class GetChatBotQuestionByIdQueryHandler
        : IRequestHandler<GetChatBotQuestionByIdQuery, BaseResponse<ChatBotQuestionDto>>
    {
        private readonly IAsyncRepository<ChatBotQuestion> _chatBotQuestionRepository;
        private readonly IAsyncRepository<WorkflowQuestion> _workflowQuestionRepository;
        private readonly IMapper _mapper;

        public GetChatBotQuestionByIdQueryHandler(IAsyncRepository<ChatBotQuestion> chatBotQuestionRepository, IAsyncRepository<WorkflowQuestion> workflowQuestionRepository, IMapper mapper)
        {
            _chatBotQuestionRepository = chatBotQuestionRepository;
            _workflowQuestionRepository = workflowQuestionRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<ChatBotQuestionDto>> Handle(GetChatBotQuestionByIdQuery request, CancellationToken cancellationToken)
        {
            var ChatBotQuestion = await _chatBotQuestionRepository
                .GetByIdAsync(request.Id);

            var data = _mapper.Map<ChatBotQuestionDto>(ChatBotQuestion);

            var WorkflowQuestions = _workflowQuestionRepository
               .Where(q => q.QuestionId == data.Id)
               .Select(q => q.Workflow)
               .ToList();

            data.WorkflowQuestions = _mapper.Map<List<WorkflowQuestionDto>>(WorkflowQuestions);
            
            return new BaseResponse<ChatBotQuestionDto>("", true, 200, data);
        }
    }
}
