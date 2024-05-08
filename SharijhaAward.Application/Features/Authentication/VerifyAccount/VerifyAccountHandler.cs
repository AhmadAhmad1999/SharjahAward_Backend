using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Authentication.VerifyAccount
{
    public class VerifyAccountHandler : IRequestHandler<VerifyAccountCommand, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;

        public VerifyAccountHandler(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public async Task<BaseResponse<object>> Handle(VerifyAccountCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            UserEntity.ConfirmationCodeForForgetPassword = null;
            UserEntity.ConfirmationCodeForResetPassword = null;
            UserEntity.ConfirmationCodeForSignUp = null;
            UserEntity.isValidAccount = true;

            await _UserRepository.UpdateAsync(UserEntity);

            ResponseMessage = Request.lang == "en"
                ? "Account has been verified successfully"
                : "تم توثيق الحساب بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
