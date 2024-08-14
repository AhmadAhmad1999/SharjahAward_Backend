using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.UpdateAssignedFormsToArbitrator
{
    public class UpdateAssignedFormsToArbitratorHandler 
        : IRequestHandler<UpdateAssignedFormsToArbitratorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;

        public UpdateAssignedFormsToArbitratorHandler(IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository)
        {
            _ArbitratorRepository = ArbitratorRepository;
            _ArbitrationRepository = ArbitrationRepository;
        }

        public async Task<BaseResponse<object>> 
            Handle(UpdateAssignedFormsToArbitratorCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitrator? ArbitratorEntity = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ArbitratorId);

            if (ArbitratorEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator not found"
                    : "المحكم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<Arbitration> ArbitrationEntitiesToDelete = await _ArbitrationRepository
                .Where(x => Request.DeleteFormsIds.Contains(x.ProvidedFormId) &&
                    x.ArbitratorId == Request.ArbitratorId)
                .ToListAsync();

            IEnumerable<Arbitration> NewArbitrationEntites = Request.NewFormsIds
                .Select(x => new Arbitration()
                {
                    ArbitratorId = Request.ArbitratorId,
                    ProvidedFormId = x,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    isAccepted = FormStatus.NotArbitratedYet,
                    isAcceptedFromChairman = FormStatus.NotArbitratedYet
                });

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
                    await _ArbitrationRepository.DeleteListAsync(ArbitrationEntitiesToDelete);

                    await _ArbitrationRepository.AddRangeAsync(NewArbitrationEntites);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Arbitrator's forms has been updated successfully"
                        : "تم تعديل الاستمارات المسندة للمحكم بنجاح";

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
