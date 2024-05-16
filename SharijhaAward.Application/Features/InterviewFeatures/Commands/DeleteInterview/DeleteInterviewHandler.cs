using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.DeleteInterview
{
    public class DeleteInterviewHandler : IRequestHandler<DeleteInterviewCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<InterviewUser> _InterviewUserRepository;
        private readonly IAsyncRepository<InterviewNote> _InterviewNoteRepository;
        private readonly IAsyncRepository<InterviewQuestion> _InterviewQuestionRepository;
        public DeleteInterviewHandler(IAsyncRepository<Interview> InterviewRepository,
            IAsyncRepository<InterviewUser> InterviewUserRepository,
            IAsyncRepository<InterviewNote> InterviewNoteRepository,
            IAsyncRepository<InterviewQuestion> InterviewQuestionRepository)
        {
            _InterviewRepository = InterviewRepository;
            _InterviewUserRepository = InterviewUserRepository;
            _InterviewNoteRepository = InterviewNoteRepository;
            _InterviewQuestionRepository = InterviewQuestionRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteInterviewCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Interview? InterviewEntityToDelete = await _InterviewRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (InterviewEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Interview is not found"
                    : "المقابلة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<InterviewUser> InterviewUserEntitiesToDelete = await _InterviewUserRepository
                .Where(x => x.InterviewId == Request.Id)
                .ToListAsync();

            List<InterviewNote> InterviewNoteEntitiesToDelete = await _InterviewNoteRepository
                .Where(x => x.InterviewId == Request.Id)
                .ToListAsync();

            List<InterviewQuestion> InterviewQuestionEntitiesToDelete = await _InterviewQuestionRepository
                .Where(x => x.InterviewId == Request.Id)
                .ToListAsync();

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
                    await _InterviewRepository.DeleteAsync(InterviewEntityToDelete);
                    await _InterviewUserRepository.DeleteListAsync(InterviewUserEntitiesToDelete);
                    await _InterviewNoteRepository.DeleteListAsync(InterviewNoteEntitiesToDelete);
                    await _InterviewQuestionRepository.DeleteListAsync(InterviewQuestionEntitiesToDelete);

                    ResponseMessage = Request.lang == "en"
                        ? "Interview has been deleted successfully"
                        : "تم حذف الاجتماع بنجاح";

                    Transaction.Complete();

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
