using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ChatBotQuestions.Commands.CreateChatBotQuestion;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ChatBotModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Commands.UpdateChatBotQuestion
{
    public class UpdateChatBotQuestionHandler : IRequestHandler<UpdateChatBotQuestionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<WorkflowQuestion> _WorkflowQuestionRepository;
        private readonly IAsyncRepository<ChatBotQuestion> _ChatBotQuestionRepository;
        private readonly IMapper _Mapper;

        public UpdateChatBotQuestionHandler(IAsyncRepository<WorkflowQuestion> _WorkflowQuestionRepository,
            IAsyncRepository<ChatBotQuestion> _ChatBotQuestionRepository,
            IMapper _Mapper)
        {
            this._WorkflowQuestionRepository = _WorkflowQuestionRepository;
            this._ChatBotQuestionRepository = _ChatBotQuestionRepository;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateChatBotQuestionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    ChatBotQuestion? EducationalClassEntityToUpdate = await _ChatBotQuestionRepository
                        .FirstOrDefaultAsync(x => x.Id == Request.Id);

                    if (EducationalClassEntityToUpdate == null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Chatbot question is not found"
                            : "السؤال غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    _Mapper.Map(Request, EducationalClassEntityToUpdate, typeof(UpdateChatBotQuestionCommand), typeof(ChatBotQuestion));

                    await _ChatBotQuestionRepository.UpdateAsync(EducationalClassEntityToUpdate);

                    List<WorkflowQuestion> OldWorkflowQuestionEntitiesToDelete = await _WorkflowQuestionRepository
                        .Where(x => x.QuestionId == Request.Id)
                        .ToListAsync();

                    await _WorkflowQuestionRepository.DeleteListAsync(OldWorkflowQuestionEntitiesToDelete);

                    if (Request.WorkflowQuestionIds is not null
                        ? Request.WorkflowQuestionIds.Any()
                        : false)
                    {
                        IEnumerable<WorkflowQuestion> NewWorkflowQuestionEntitiesToAdd = Request.WorkflowQuestionIds
                            .Select(x => new WorkflowQuestion()
                            {
                                QuestionId = Request.Id,
                                WorkflowId = x
                            });

                        await _WorkflowQuestionRepository.AddRangeAsync(NewWorkflowQuestionEntitiesToAdd);
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Chatbot question has been updated successfully"
                        : "تم تعديل السؤال بنجاح";

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
