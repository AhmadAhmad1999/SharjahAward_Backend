using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.RejectInitialArbiitrationFromArbitrationAudit
{
    public class RejectInitialArbiitrationFromArbitrationAuditHandler
        : IRequestHandler<RejectInitialArbiitrationFromArbitrationAuditCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        public RejectInitialArbiitrationFromArbitrationAuditHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
        }

        public async Task<BaseResponse<object>> Handle(RejectInitialArbiitrationFromArbitrationAuditCommand Request, CancellationToken cancellationToken)
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
                    await _ArbitrationRepository
                        .Where(x => x.ProvidedFormId == Request.FormId)
                        .ExecuteUpdateAsync(x => x.SetProperty(y => y.IsRejectedFromArbitrationAuditStep, true));

                    FinalArbitration? FinalArbitrationEntity = await _FinalArbitrationRepository
                        .FirstOrDefaultAsync(x => x.ProvidedFormId == Request.FormId);

                    if (FinalArbitrationEntity is not null)
                        await _FinalArbitrationRepository.DeleteAsync(FinalArbitrationEntity);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Initial arbitration has been rejected successfully"
                        : "تم رفض التحكيم على الاستمارة بنجاح";

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
