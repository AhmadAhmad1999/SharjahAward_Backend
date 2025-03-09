using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ProvidedForm.Command.OpenFormForUpdate
{
    public class OpenFormForUpdateHandler
        : IRequestHandler<OpenFormForUpdateCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;

        public OpenFormForUpdateHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository)
        {
            this._ProvidedFormRepository = _ProvidedFormRepository;
        }
        public async Task<BaseResponse<object>>
            Handle(OpenFormForUpdateCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ProvidedFormId);

            if (ProvidedFormEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Provided form is not found"
                    : "استمارة المشترك غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (ProvidedFormEntity.PercentCompletion != 100)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Provided form is not complete, so you can't open it for update again"
                    : "استمارة المشترك غير مكتملة ولذلك لا يمكنك فتحها للتعديل من جديد";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            ProvidedFormEntity.PercentCompletion = 99;
            ProvidedFormEntity.needSing = true;
            await _ProvidedFormRepository.UpdateAsync(ProvidedFormEntity);

            ResponseMessage = Request.lang == "en"
                ? "Provided form is successfully opened for update"
                : "تم فتح استمارة المشترك للتعديل من جديد";

            return new BaseResponse<object>(ResponseMessage, false, 200);
        }
    }
}
