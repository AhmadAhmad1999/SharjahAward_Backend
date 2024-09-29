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
        : IRequestHandler<TalkWithChatBotQuery, BaseResponse<ConversationDto>>
    {
        private readonly IAsyncRepository<ChatBotQuestion> _chatBotQuestionRepository;
        private readonly IAsyncRepository<WorkflowQuestion> _workflowQuestionRepository;

        public TalkWithChatBotQueryHandler(IAsyncRepository<ChatBotQuestion> chatBotQuestionRepository, IAsyncRepository<WorkflowQuestion> workflowQuestionRepository, IMapper mapper)
        {
            _chatBotQuestionRepository = chatBotQuestionRepository;
            _workflowQuestionRepository = workflowQuestionRepository;
        }

        public async Task<BaseResponse<ConversationDto>> Handle(TalkWithChatBotQuery request, CancellationToken cancellationToken)
        {
            var Question = await _chatBotQuestionRepository.GetByIdAsync(request.QuestionId);
            
            if(Question == null)
            {
                return new BaseResponse<ConversationDto>("", false, 200, null!);
            }

            var workFlow = _workflowQuestionRepository
                .Where(q => q.QuestionId == Question.Id)
                .Select(q => q.Workflow)
                .ToList();


            var data = new ConversationDto()
            {
                Id = Question.Id,
                Answer = request.lang == "en" ? Question.EnglishAnswer : Question.ArabicAnswer,
                Workflow = workFlow.Select(q => new ConversationWorkflowListVM()
                {
                    Id = q.Id,
                    Question = request.lang == "en" ? q.EnglishQuestion : q.ArabicQuestion
                
                }).ToList()
            };


            return new BaseResponse<ConversationDto>("", true, 200, data);
        }
    }
}
