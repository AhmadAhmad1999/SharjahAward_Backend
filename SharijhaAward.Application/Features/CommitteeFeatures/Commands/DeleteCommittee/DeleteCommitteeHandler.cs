using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryCommitteeModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;
using SharijhaAward.Domain.Entities.CommitteeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Commands.DeleteCommittee
{
    public class DeleteCommitteeHandler : IRequestHandler<DeleteCommitteeCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Committee> _CommitteeRepository;
        private readonly IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository;
        private readonly IAsyncRepository<CategoryCommittee> _CategoryCommitteeRepository;

        public DeleteCommitteeHandler(IAsyncRepository<Committee> CommitteeRepository,
            IAsyncRepository<ComitteeArbitrator> ComitteeArbitratorRepository,
            IAsyncRepository<CategoryCommittee> CategoryCommitteeRepository)
        {
            _CommitteeRepository = CommitteeRepository;
            _ComitteeArbitratorRepository = ComitteeArbitratorRepository;
            _CategoryCommitteeRepository = CategoryCommitteeRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteCommitteeCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Committee? CommitteeEntityToDelete = await _CommitteeRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CommitteeEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Committee is not found"
                    : "اللجنة غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

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
                    await _CommitteeRepository.DeleteAsync(CommitteeEntityToDelete);

                    IQueryable<ComitteeArbitrator> ComitteeArbitratorEntitiesToDelete = _ComitteeArbitratorRepository
                        .Where(x => x.CommitteeId == Request.Id);

                    await _ComitteeArbitratorRepository.DeleteListAsync(ComitteeArbitratorEntitiesToDelete);

                    IQueryable<CategoryCommittee> CategoryCommitteeEntitiesToDelete = _CategoryCommitteeRepository
                        .Where(x => x.CommitteeId == Request.Id);

                    await _CategoryCommitteeRepository.DeleteListAsync(CategoryCommitteeEntitiesToDelete);

                    ResponseMessage = Request.lang == "en"
                        ? "Committee has been deleted successfully"
                        : "تم حذف اللجنة بنجاح";

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
