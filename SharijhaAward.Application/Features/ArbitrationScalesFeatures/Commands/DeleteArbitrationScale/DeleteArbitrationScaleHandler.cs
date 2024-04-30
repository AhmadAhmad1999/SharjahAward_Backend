using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationScaleModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Commands.DeleteArbitrationScale
{
    public class DeleteArbitrationScaleHandler : IRequestHandler<DeleteArbitrationScaleCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ArbitrationScale> _ArbitrationScaleRepository;
        private readonly IAsyncRepository<ArbitrationScalesCriterion> _ArbitrationScalesCriterionRepository;
        public DeleteArbitrationScaleHandler(IAsyncRepository<ArbitrationScale> ArbitrationScaleRepository,
            IAsyncRepository<ArbitrationScalesCriterion> ArbitrationScalesCriterionRepository)
        {
            _ArbitrationScaleRepository = ArbitrationScaleRepository;
            _ArbitrationScalesCriterionRepository = ArbitrationScalesCriterionRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteArbitrationScaleCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ArbitrationScale? ArbitrationScaleEntityToDelete = await _ArbitrationScaleRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ArbitrationScaleEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitration scale is not found"
                    : "المقياس غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<ArbitrationScalesCriterion> ArbitrationScalesCriterionEntitiesToDelete = await _ArbitrationScalesCriterionRepository
                .Where(x => x.ArbitrationScaleId == Request.Id)
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
                    await _ArbitrationScaleRepository.DeleteAsync(ArbitrationScaleEntityToDelete);

                    await _ArbitrationScalesCriterionRepository.DeleteListAsync(ArbitrationScalesCriterionEntitiesToDelete);

                    ResponseMessage = Request.lang == "en"
                        ? "Arbitration scale has been deleted successfully"
                        : "تم حذف المقياس بنجاح";

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
