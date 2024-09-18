using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.SwitchArbitrationFeature
{
    public class SwitchArbitrationHandler : IRequestHandler<SwitchArbitrationCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<SwitchArbitration> _SwitchArbitrationRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;

        public SwitchArbitrationHandler(IAsyncRepository<SwitchArbitration> SwitchArbitrationRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository)
        {
            _SwitchArbitrationRepository = SwitchArbitrationRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _ArbitratorRepository = ArbitratorRepository;
        }

        public async Task<BaseResponse<object>> Handle(SwitchArbitrationCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitrator? CheckArbitratorId = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.OldArbitratorId);

            if (CheckArbitratorId == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator is not found"
                    : "المحكم غير موجود";

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
                    int NumberOfAffectedArbitrationEntities = await _ArbitrationRepository
                        .Where(x => x.ArbitratorId == Request.OldArbitratorId &&
                            x.ProvidedFormId == Request.ProvidedFormId)
                        .ExecuteUpdateAsync(x => x.SetProperty(y => y.ArbitratorId, Request.NewArbitratorId));

                    if (NumberOfAffectedArbitrationEntities > 0)
                    {
                        SwitchArbitration NewSwitchArbitrationEntity = new SwitchArbitration()
                        {
                            OldArbitratorId = Request.OldArbitratorId,
                            NewArbitratorId = Request.NewArbitratorId,
                            ProvidedFormId = Request.ProvidedFormId
                        };

                        await _SwitchArbitrationRepository.AddAsync(NewSwitchArbitrationEntity);
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء المحكم بنجاح";

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
