using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.ChangeArbitrationStatus
{
    public class ChangeArbitrationStatusHandler : IRequestHandler<ChangeArbitrationStatusMainCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<ChairmanNotesOnInitialArbitration> _ChairmanNotesOnInitialArbitrationRepository;
        public ChangeArbitrationStatusHandler(IAsyncRepository<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationRepository, 
            IAsyncRepository<Arbitration> ArbitrationRepository)
        {
            _ChairmanNotesOnInitialArbitrationRepository = ChairmanNotesOnInitialArbitrationRepository;
            _ArbitrationRepository = ArbitrationRepository;
        }

        public async Task<BaseResponse<object>> Handle(ChangeArbitrationStatusMainCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitration? ArbitrationEntity = await _ArbitrationRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ArbitrationId);

            if (ArbitrationEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitration is not Found"
                    : "التحكيم غير موجود";

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
                    ArbitrationEntity.isAcceptedFromChairman = Request.isAccepted;

                    if (!Request.isAccepted)
                    {
                        ArbitrationEntity.Type = ArbitrationType.BeingReviewed;

                        IEnumerable<ChairmanNotesOnInitialArbitration> NewChairmanNotesOnInitialArbitrationEntities = Request.ChairmanNotes
                            .Select(x => new ChairmanNotesOnInitialArbitration()
                            {
                                Note = x.Note,
                                InitialArbitrationId = x.InitialArbitrationId
                            });

                        await _ChairmanNotesOnInitialArbitrationRepository.AddRangeAsync(NewChairmanNotesOnInitialArbitrationEntities);
                    }

                    await _ArbitrationRepository.UpdateAsync(ArbitrationEntity);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : (Request.isAccepted 
                            ? "تم قبول التحكيم بنجاح"
                            : "تم رفض التحكيم بنجاح");

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
