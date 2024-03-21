using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Authentication.CheckConfirmationCodeForSignUp
{
    internal class CheckConfirmationCodeForSignUpHandler : IRequestHandler<CheckConfirmationCodeForSignUpCommand, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        public CheckConfirmationCodeForSignUpHandler(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public async Task<BaseResponse<object>> Handle(CheckConfirmationCodeForSignUpCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository.FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (UserEntity.ConfirmationCodeForResetPassword != Request.ConfirmationCode)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Invalid confirmation code"
                    : "رقم تحقق غير فعال";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            UserEntity.ConfirmationCodeForSignUp = null;
            await _UserRepository.UpdateAsync(UserEntity);

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
