using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ChatBotModel;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetAllChatBotQuestions
{
    public class GetAllChatBotQuestionsQueryHandler
        : IRequestHandler<GetAllChatBotQuestionsQuery, BaseResponse<List<ChatBotQuestionsListVM>>>
    {
        private readonly IAsyncRepository<ChatBotQuestion> _ChatBotQuestionRepository;

        public GetAllChatBotQuestionsQueryHandler(IAsyncRepository<ChatBotQuestion> _ChatBotQuestionRepository)
        {
            this._ChatBotQuestionRepository = _ChatBotQuestionRepository;
        }

        public async Task<BaseResponse<List<ChatBotQuestionsListVM>>> Handle(GetAllChatBotQuestionsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<ChatBotQuestionsListVM> Response = await _ChatBotQuestionRepository
                .OrderByDescending(x => x.CreatedBy, Request.page, Request.perPage)
                .Select(x => new ChatBotQuestionsListVM()
                {
                    Id = x.Id,
                    Question = Request.lang == "en"
                        ? x.EnglishQuestion
                        : x.ArabicQuestion,
                    Answer = Request.lang == "en"
                        ? x.EnglishAnswer
                        : x.ArabicAnswer,
                    Initial = x.Initial
                }).ToListAsync();

            int TotalCount = await _ChatBotQuestionRepository.GetCountAsync(null);
            
            Pagination pagination = new Pagination(Request.page, Request.perPage, TotalCount);

            return new BaseResponse<List<ChatBotQuestionsListVM>>(ResponseMessage, true, 200, Response, pagination);
        }
    }
}
