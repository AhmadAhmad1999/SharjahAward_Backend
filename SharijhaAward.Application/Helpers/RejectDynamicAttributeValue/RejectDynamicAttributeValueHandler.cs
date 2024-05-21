using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Helpers.RejectDynamicAttributeValue
{
    public class RejectDynamicAttributeValueHandler : IRequestHandler<RejectDynamicAttributeValueMainCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        public RejectDynamicAttributeValueHandler(IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }
        public async Task<BaseResponse<object>> Handle(RejectDynamicAttributeValueMainCommand Request, CancellationToken cancellationToken)
        {
            List<DynamicAttributeValue> DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                .Where(x => Request.RejectDynamicAttributeValueCommand.Select(y => y.DynamicAttributesId).Contains(x.DynamicAttributeId))
                .ToListAsync();

            foreach (DynamicAttributeValue DynamicAttributeValueEntity in DynamicAttributeValueEntities)
            {
                RejectDynamicAttributeValueCommand RequestCommand = Request.RejectDynamicAttributeValueCommand
                    .FirstOrDefault(x => x.DynamicAttributesId == DynamicAttributeValueEntity.DynamicAttributeId)!;

                DynamicAttributeValueEntity.isAccepted = RequestCommand.isAccepted;
                DynamicAttributeValueEntity.ReasonForRejecting = RequestCommand.ReasonForRejecting;
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
                    await _DynamicAttributeValueRepository.UpdateListAsync(DynamicAttributeValueEntities);

                    Transaction.Complete();

                    string ResponseMessage = Request.lang == "en"
                        ? "Fields has been rejected successfully"
                        : "تم رفض الحقول بنجاح";

                    return new BaseResponse<object>();
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
