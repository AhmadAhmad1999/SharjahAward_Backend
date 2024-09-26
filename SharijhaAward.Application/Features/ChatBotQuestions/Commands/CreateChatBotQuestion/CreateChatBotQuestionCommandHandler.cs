using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ChatBotModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Commands.CreateChatBotQuestion
{
    public class CreateChatBotQuestionCommandHandler
        : IRequestHandler<CreateChatBotQuestionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ChatBotQuestion> _chatBotQuestionRepository;
        private readonly IAsyncRepository<WorkflowQuestion> _workflowQuestionRepository;
        private readonly IMapper _mapper;

        public CreateChatBotQuestionCommandHandler(IAsyncRepository<WorkflowQuestion> workflowQuestionRepository, IAsyncRepository<ChatBotQuestion> chatBotQuestionRepository, IMapper mapper)
        {
            _chatBotQuestionRepository = chatBotQuestionRepository;
            _workflowQuestionRepository = workflowQuestionRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateChatBotQuestionCommand request, CancellationToken cancellationToken)
        {
            var question = _mapper.Map<ChatBotQuestion>(request);

            var data = await _chatBotQuestionRepository.AddAsync(question);
           
            if (request.WorkflowQuestionIds != null && request.WorkflowQuestionIds.Count() > 0)
            {
                foreach(var item in request.WorkflowQuestionIds)
                {
                    await _workflowQuestionRepository.AddAsync(
                    new WorkflowQuestion()
                    {
                        QuestionId = data.Id,
                        WorkflowId = item
                    });
                }
            }
            return new BaseResponse<object>("تم إضافة السؤال بنجاح", true, 200);
        }
    }
}
