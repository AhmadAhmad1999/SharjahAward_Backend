using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.UserFeatures.Commands.ChangePassword
{
    public class ChangePasswordHandler : IRequestHandler<ChangePasswordCommand, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;

        public ChangePasswordHandler(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }
        public async Task<BaseResponse<object>> Handle(ChangePasswordCommand Request, CancellationToken cancellationToken)
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

            byte[] salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

            UserEntity.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: Request.NewPassword,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            await _UserRepository.UpdateAsync(UserEntity);

            ResponseMessage = Request.lang == "en"
                ? "User's password has been updated successfully"
                : "تم تعديل كلمة مرور المستخدم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
