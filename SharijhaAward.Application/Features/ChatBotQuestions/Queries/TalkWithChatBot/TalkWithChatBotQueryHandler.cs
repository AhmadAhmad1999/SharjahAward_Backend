using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ChatBotModel;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.TalkWithChatBot
{
    public class TalkWithChatBotQueryHandler
        : IRequestHandler<TalkWithChatBotQuery, BaseResponse<ConversationDto>>
    {
        private readonly IAsyncRepository<ChatBotQuestion> _ChatBotQuestionRepository;
        private readonly IAsyncRepository<WorkflowQuestion> _WorkflowQuestionRepository;

        public TalkWithChatBotQueryHandler(IAsyncRepository<ChatBotQuestion> _ChatBotQuestionRepository, 
            IAsyncRepository<WorkflowQuestion> _WorkflowQuestionRepository)
        {
            this._ChatBotQuestionRepository = _ChatBotQuestionRepository;
            this._WorkflowQuestionRepository = _WorkflowQuestionRepository;
        }

        public async Task<BaseResponse<ConversationDto>> Handle(TalkWithChatBotQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ChatBotQuestion? ChatBotQuestionEntity = await _ChatBotQuestionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.QuestionId);
            
            if(ChatBotQuestionEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Chatbot question is not found"
                    : "السؤال غير موجود";

                return new BaseResponse<ConversationDto>(ResponseMessage, false, 404);
            }

            List<ChatBotQuestion> WorkflowQuestionEntities = _WorkflowQuestionRepository
                .Where(x => x.QuestionId == ChatBotQuestionEntity.Id)
                .Select(x => x.Workflow)
                .ToList();

            ConversationDto Response = new ConversationDto()
            {
                Id = ChatBotQuestionEntity.Id,
                Answer = Request.lang == "en" 
                    ? ChatBotQuestionEntity.EnglishAnswer 
                    : ChatBotQuestionEntity.ArabicAnswer,
                Workflow = WorkflowQuestionEntities.Select(x => new ConversationWorkflowListVM()
                {
                    Id = x.Id,
                    Question = Request.lang == "en" 
                        ? x.EnglishQuestion 
                        : x.ArabicQuestion
                }).ToList()
            };

            return new BaseResponse<ConversationDto>(ResponseMessage, true, 200, Response);
        }
    }
}
