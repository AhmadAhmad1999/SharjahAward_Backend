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
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        public RejectDynamicAttributeValueHandler(IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository)
        {
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
        }
        public async Task<BaseResponse<object>> Handle(RejectDynamicAttributeValueMainCommand Request, CancellationToken cancellationToken)
        {
            List<DynamicAttributeValue> DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                .Where(x => Request.RejectDynamicAttributeValueCommand.Select(y => y.DynamicAttributesId).Contains(x.DynamicAttributeId))
                .ToListAsync();

            foreach (DynamicAttributeValue DynamicAttributeValueEntity in DynamicAttributeValueEntities)
            {
                RejectDynamicAttributeValueCommand? RequestCommand = Request.RejectDynamicAttributeValueCommand
                    .FirstOrDefault(x => x.DynamicAttributesId == DynamicAttributeValueEntity.DynamicAttributeId);

                if (RequestCommand is not null)
                {
                    DynamicAttributeValueEntity.isAccepted = RequestCommand.isAccepted;
                    DynamicAttributeValueEntity.ReasonForRejecting = RequestCommand.ReasonForRejecting;
                }
            }

            List<DynamicAttributeTableValue> DynamicAttributeTableValueEntities = await _DynamicAttributeTableValueRepository
                .Where(x => Request.RejectDynamicAttributeValueCommand.Select(y => y.DynamicAttributesId).Contains(x.DynamicAttributeId))
                .ToListAsync();

            foreach (DynamicAttributeTableValue DynamicAttributeTableValueEntity in DynamicAttributeTableValueEntities)
            {
                RejectDynamicAttributeValueCommand? RequestCommand = Request.RejectDynamicAttributeValueCommand
                    .FirstOrDefault(x => x.DynamicAttributesId == DynamicAttributeTableValueEntity.DynamicAttributeId && 
                        x.RowId == DynamicAttributeTableValueEntity.RowId);

                if (RequestCommand is not null)
                {
                    DynamicAttributeTableValueEntity.isAccepted = RequestCommand.isAccepted;
                    DynamicAttributeTableValueEntity.ReasonForRejecting = RequestCommand.ReasonForRejecting;
                }
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
                    await _DynamicAttributeTableValueRepository.UpdateListAsync(DynamicAttributeTableValueEntities);

                    Transaction.Complete();

                    string ResponseMessage = Request.lang == "en"
                        ? "Field's acceptance status has been successfully changed"
                        : "تم تغيير حالة قبول الحقل بنجاح";

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
