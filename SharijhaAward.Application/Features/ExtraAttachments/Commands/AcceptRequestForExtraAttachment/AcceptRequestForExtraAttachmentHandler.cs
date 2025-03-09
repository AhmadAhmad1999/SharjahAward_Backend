using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ExtraAttachments.Commands.AcceptRequestForExtraAttachment
{
    public class AcceptRequestForExtraAttachmentHandler 
        : IRequestHandler<AcceptRequestForExtraAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ExtraAttachment> _ExtraAttachmentRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        public AcceptRequestForExtraAttachmentHandler(IAsyncRepository<ExtraAttachment> _ExtraAttachmentRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository)
        {
            this._ExtraAttachmentRepository = _ExtraAttachmentRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
        }
        public async Task<BaseResponse<object>> 
            Handle(AcceptRequestForExtraAttachmentCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ExtraAttachment? ExtraAttachmentEntity = await _ExtraAttachmentRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ExtraAttachmentId);

            if (ExtraAttachmentEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Extra attachment is not found"
                    : "المرفق الإضافي غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (ExtraAttachmentEntity.isAccepted)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Extra attachment is already accepted"
                    : "طلب إضافة المرفق الإضافي مقبول مسبقاً";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == ExtraAttachmentEntity.ProvidedFormId);

            if (ProvidedFormEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Provided form is not found"
                    : "الإستمارة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (ProvidedFormEntity.TotalStep == 6)
            {
                ProvidedFormEntity.TotalStep++;

                var PercentFormula = ((ProvidedFormEntity.CurrentStep - 1) * 100) / ProvidedFormEntity.TotalStep;
                ProvidedFormEntity.PercentCompletion = PercentFormula < 0 ? 0 : PercentFormula;
                ProvidedFormEntity.needSing = true;
            }

            ExtraAttachmentEntity.isAccepted = true;

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
                    await _ProvidedFormRepository.UpdateAsync(ProvidedFormEntity);
                    await _ExtraAttachmentRepository.UpdateAsync(ExtraAttachmentEntity);

                    ResponseMessage = Request.lang == "en"
                        ? "Request for extra attachment is accepted successfully"
                        : "تمت الموافقة على طلب المرفق الإضافي بنجاح";

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
