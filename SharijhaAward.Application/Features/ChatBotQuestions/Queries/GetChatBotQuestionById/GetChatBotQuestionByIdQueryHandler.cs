using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetAllChatBotQuestions;
using SharijhaAward.Application.Features.Classes.Queries.GetClassById;
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
        private readonly IAsyncRepository<ChatBotQuestion> _ChatBotQuestionRepository;
        private readonly IAsyncRepository<WorkflowQuestion> _WorkflowQuestionRepository;
        private readonly IMapper _mapper;

        public GetChatBotQuestionByIdQueryHandler(IAsyncRepository<ChatBotQuestion> chatBotQuestionRepository, IAsyncRepository<WorkflowQuestion> workflowQuestionRepository, IMapper mapper)
        {
            _ChatBotQuestionRepository = chatBotQuestionRepository;
            _WorkflowQuestionRepository = workflowQuestionRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<ChatBotQuestionDto>> Handle(GetChatBotQuestionByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ChatBotQuestion? ChatBotQuestionEntity = await _ChatBotQuestionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ChatBotQuestionEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Chatbot question is not found"
                    : "السؤال غير موجود";

                return new BaseResponse<ChatBotQuestionDto>(ResponseMessage, false, 404);
            }

            List<ChatBotQuestion> WorkflowQuestionsEntities = await _WorkflowQuestionRepository
               .Where(x => x.QuestionId == ChatBotQuestionEntity.Id)
               .Select(x => x.Workflow)
               .ToListAsync();

            ChatBotQuestionDto Response = new ChatBotQuestionDto()
            {
                Id = ChatBotQuestionEntity.Id,
                EnglishAnswer = ChatBotQuestionEntity.EnglishAnswer,
                ArabicAnswer = ChatBotQuestionEntity.ArabicAnswer,
                ArabicQuestion = ChatBotQuestionEntity.ArabicQuestion,
                EnglishQuestion = ChatBotQuestionEntity.EnglishQuestion,
                Initial = ChatBotQuestionEntity.Initial,
                WorkflowQuestions = WorkflowQuestionsEntities
                    .Select(y => new WorkflowQuestionDto()
                    {
                        Id = y.Id,
                        EnglishAnswer = y.EnglishAnswer,
                        ArabicAnswer = y.ArabicAnswer,
                        ArabicQuestion = y.ArabicQuestion,
                        EnglishQuestion = y.EnglishQuestion,
                        Initial = y.Initial,
                    }).ToList()
            };

            return new BaseResponse<ChatBotQuestionDto>(ResponseMessage, true, 200, Response);
        }
    }
}
