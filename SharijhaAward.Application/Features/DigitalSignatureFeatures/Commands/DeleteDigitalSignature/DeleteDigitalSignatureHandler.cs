using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DigitalSignatureModel;
using System.Net.Http;
using System.Transactions;

namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Commands.DeleteDigitalSignature
{
    public class DeleteDigitalSignatureHandler : IRequestHandler<DeleteDigitalSignatureCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DigitalSignature> _DigitalSignatureRepository;
        public DeleteDigitalSignatureHandler(IAsyncRepository<DigitalSignature> DigitalSignatureRepository)
        {
            _DigitalSignatureRepository = DigitalSignatureRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteDigitalSignatureCommand Request, CancellationToken cancellationToken)
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
                    DigitalSignature? DigitalSignatureEntityToDelete = await _DigitalSignatureRepository
                        .FirstOrDefaultAsync(x => x.Id == Request.Id);

                    if (DigitalSignatureEntityToDelete == null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Digital signature is not found"
                            : "التوقيع الرقمي غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    await _DigitalSignatureRepository.DeleteAsync(DigitalSignatureEntityToDelete);

                    if (File.Exists(DigitalSignatureEntityToDelete.ImageUrl))
                        File.Delete(DigitalSignatureEntityToDelete.ImageUrl);

                    ResponseMessage = Request.lang == "en"
                        ? "Digital signature has been deleted successfully"
                        : "تم حذف التوقيع الرقمي بنجاح";

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
