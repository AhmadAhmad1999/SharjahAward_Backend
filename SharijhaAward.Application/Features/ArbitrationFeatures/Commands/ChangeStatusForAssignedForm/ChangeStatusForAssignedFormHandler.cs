using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.ChangeStatusForAssignedForm
{
    public class ChangeStatusForAssignedFormHandler : IRequestHandler<ChangeStatusForAssignedFormCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        public ChangeStatusForAssignedFormHandler(IAsyncRepository<Arbitration> ArbitrationRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
        }

        public async Task<BaseResponse<object>> Handle(ChangeStatusForAssignedFormCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitration? ArbitrationEntity = await _ArbitrationRepository.GetByIdAsync(Request.Id);

            if (ArbitrationEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitration not found"
                    : "هذا التحكيم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            ArbitrationEntity.isAccepted = Request.isAccepted;
            await _ArbitrationRepository.UpdateAsync(ArbitrationEntity);

            ResponseMessage = Request.lang == "en"
                ? "Form's status has been updated successfully"
                : "تم تعديل حالة الاستمارة المسندة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
