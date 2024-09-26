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

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetAllChatBotQuestions
{
    public class GetAllChatBotQuestionsQueryHandler
        : IRequestHandler<GetAllChatBotQuestionsQuery, BaseResponse<List<ChatBotQuestionsListVM>>>
    {
        private readonly IAsyncRepository<ChatBotQuestion> _chatBotQuestionRepository;
        private readonly IAsyncRepository<WorkflowQuestion> _workflowQuestionRepository;
        private readonly IMapper _mapper;          

        public GetAllChatBotQuestionsQueryHandler(IAsyncRepository<ChatBotQuestion> chatBotQuestionRepository, IAsyncRepository<WorkflowQuestion> workflowQuestionRepository, IMapper mapper)
        {
            _chatBotQuestionRepository = chatBotQuestionRepository;
            _workflowQuestionRepository = workflowQuestionRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<ChatBotQuestionsListVM>>> Handle(GetAllChatBotQuestionsQuery request, CancellationToken cancellationToken)
        {
            var ChatBotQuestions = await _chatBotQuestionRepository
                .GetPagedReponseAsync(request.page, request.perPage);

            var data = _mapper.Map<List<ChatBotQuestionsListVM>>(ChatBotQuestions);

            foreach(var item in data)
            {
                var WorkflowQuestions = _workflowQuestionRepository
                    .Where(q => q.QuestionId == item.Id)
                    .Select(q => q.Workflow)
                    .ToList();

                item.WorkflowQuestions = _mapper.Map<List<WorkflowQuestionDto>>(WorkflowQuestions);
            }

            var count = _chatBotQuestionRepository.GetCount(null);

            Pagination pagination = new Pagination(request.page, request.perPage, count);

            return new BaseResponse<List<ChatBotQuestionsListVM>>("", true, 200, data, pagination);

        }
    }
}
