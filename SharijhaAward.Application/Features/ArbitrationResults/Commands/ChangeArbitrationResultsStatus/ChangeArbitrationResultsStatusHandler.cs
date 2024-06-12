using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;

namespace SharijhaAward.Application.Features.ArbitrationResults.Commands.ChangeArbitrationResultsStatus
{
    public class ChangeArbitrationResultsStatusHandler 
        : IRequestHandler<ChangeArbitrationResultsStatusCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        public ChangeArbitrationResultsStatusHandler(IAsyncRepository<ArbitrationResult> ArbitrationResultRepository)
        {
            _ArbitrationResultRepository = ArbitrationResultRepository;
        }

        public async Task<BaseResponse<object>> 
            Handle(ChangeArbitrationResultsStatusCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ArbitrationResult? ArbitrationResultEntityToUpdate = await _ArbitrationResultRepository
                .FirstOrDefaultAsync(x => x.ProvidedFormId == Request.FormId);

            if (ArbitrationResultEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitration result is not found"
                    : "نتيجة التحكيم غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (Request.isCerticate)
            {
                if (!ArbitrationResultEntityToUpdate.GotCertification)
                {
                    ArbitrationResultEntityToUpdate.GotCertification = !ArbitrationResultEntityToUpdate.GotCertification;
                    ArbitrationResultEntityToUpdate.DateOfObtainingTheCertificate = DateTime.UtcNow;
                }
                else
                {
                    ArbitrationResultEntityToUpdate.GotCertification = !ArbitrationResultEntityToUpdate.GotCertification;

                    if (ArbitrationResultEntityToUpdate.DateOfObtainingTheCertificate is not null)
                        ArbitrationResultEntityToUpdate.DateOfObtainingTheCertificate = null;
                }
            }
            else
            {
                if (!ArbitrationResultEntityToUpdate.GotStatement)
                {
                    ArbitrationResultEntityToUpdate.GotStatement = !ArbitrationResultEntityToUpdate.GotStatement;
                    ArbitrationResultEntityToUpdate.DateOfObtainingTheStatement = DateTime.UtcNow;
                }
                else
                {
                    ArbitrationResultEntityToUpdate.GotStatement = !ArbitrationResultEntityToUpdate.GotStatement;

                    if (ArbitrationResultEntityToUpdate.DateOfObtainingTheStatement is not null)
                        ArbitrationResultEntityToUpdate.DateOfObtainingTheStatement = null;
                }
            }

            await _ArbitrationResultRepository.UpdateAsync(ArbitrationResultEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Arbitration result has been deleted successfully"
                : "تم تعديل نتيجة التحكيم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
