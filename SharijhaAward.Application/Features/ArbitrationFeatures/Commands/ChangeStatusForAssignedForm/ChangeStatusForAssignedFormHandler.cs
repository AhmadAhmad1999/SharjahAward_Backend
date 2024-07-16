using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.ChangeStatusForAssignedForm
{
    public class ChangeStatusForAssignedFormHandler : IRequestHandler<ChangeStatusForAssignedFormCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IJwtProvider _JWTProvider;

        public ChangeStatusForAssignedFormHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IJwtProvider JWTProvider)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<object>> Handle(ChangeStatusForAssignedFormCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

            Arbitration? ArbitrationEntity = await _ArbitrationRepository
                .Include(x => x.Arbitrator!)
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ArbitrationEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitration not found"
                    : "هذا التحكيم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (ArbitrationEntity.ArbitratorId == UserId && ArbitrationEntity.Arbitrator!.isChairman)
            {
                ArbitrationEntity.isAccepted = Request.isAccepted;
                ArbitrationEntity.isAcceptedFromChairman = Request.isAcceptedFromChairman;

                await _ArbitrationRepository.UpdateAsync(ArbitrationEntity);

                ResponseMessage = Request.lang == "en"
                    ? "Form's status has been updated successfully"
                    : "تم تعديل حالة الاستمارة المسندة بنجاح";

                return new BaseResponse<object>(ResponseMessage, true, 200);
            }

            ArbitrationEntity.isAccepted = Request.isAccepted;
            
            if (Request.isAccepted == FormStatus.Rejected)
                ArbitrationEntity.ReasonForRejecting = Request.ReasonForRejecting;

            await _ArbitrationRepository.UpdateAsync(ArbitrationEntity);

            ResponseMessage = Request.lang == "en"
                ? "Form's status has been updated successfully"
                : "تم تعديل حالة الاستمارة المسندة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
