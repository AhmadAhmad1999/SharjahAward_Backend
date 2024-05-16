using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.AddFinalScoreToArbitratoinForFormId
{
    public class AddFinalScoreToArbitratoinForFormIdHandler
        : IRequestHandler<AddFinalScoreToArbitratoinForFormIdCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;

        public AddFinalScoreToArbitratoinForFormIdHandler(IAsyncRepository<Arbitration> ArbitrationRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
        }

        public async Task<BaseResponse<object>> Handle(AddFinalScoreToArbitratoinForFormIdCommand Request, CancellationToken cancellationToken)
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
                        .ExecuteUpdateAsync(x => x.SetProperty(y => y.FullScore, Request.FinalScore));

                    await _ArbitrationRepository
                        .Where(x => x.ProvidedFormId == Request.FormId)
                        .ExecuteUpdateAsync(x => x.SetProperty(y => y.IsRejectedFromArbitrationAuditStep, false));

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Final score has been updated successfully"
                        : "تم تعديل العلامة النهائية بنجاح";

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
