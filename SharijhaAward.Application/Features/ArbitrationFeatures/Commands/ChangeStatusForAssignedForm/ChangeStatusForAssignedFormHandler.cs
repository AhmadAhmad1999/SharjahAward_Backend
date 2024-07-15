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
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JWTProvider;

        public ChangeStatusForAssignedFormHandler(IUserRepository UserRepository, IAsyncRepository<Arbitration> ArbitrationRepository,
            IJwtProvider JWTProvider)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _UserRepository = UserRepository;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<object>> Handle(ChangeStatusForAssignedFormCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;
            
            var UserId = _JWTProvider.GetUserIdFromToken(Request.token!);
            if(UserId == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Un Auth"
                    : "غير مصرح له بالدخول";

                return new BaseResponse<object>(ResponseMessage, false, 401);
            }

            Arbitration? ArbitrationEntity = await _ArbitrationRepository.WhereThenInclude(a => a.Id == Request.Id, a => a.Arbitrator!).FirstOrDefaultAsync();

            if (ArbitrationEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitration not found"
                    : "هذا التحكيم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (ArbitrationEntity.ArbitratorId == int.Parse(UserId) && ArbitrationEntity.Arbitrator!.isChairman)
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
            
            if (!Request.isAccepted)
                ArbitrationEntity.ReasonForRejecting = Request.ReasonForRejecting;

            await _ArbitrationRepository.UpdateAsync(ArbitrationEntity);

            ResponseMessage = Request.lang == "en"
                ? "Form's status has been updated successfully"
                : "تم تعديل حالة الاستمارة المسندة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
