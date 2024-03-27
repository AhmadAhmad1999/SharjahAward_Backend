using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.ResetPassword
{
    public class ResetPasswordHandler : IRequestHandler<ResetPasswordCommand, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JWTProvider;

        public ResetPasswordHandler(IUserRepository UserRepository, 
            IJwtProvider JWTProvider)
        {
            _UserRepository = UserRepository;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<object>> Handle(ResetPasswordCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Guid UserID = new Guid(_JWTProvider.GetUserIdFromToken(Request.Token!));
            
            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository.FirstOrDefaultAsync(x => x.Id == UserID);
            
            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            byte[] salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };
            string NewPasswordAfterHashing = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: Request.NewPassword,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            UserEntity.Password = NewPasswordAfterHashing;

            await _UserRepository.UpdateAsync(UserEntity);

            ResponseMessage = Request.lang == "en"
                ? "Your password has been updated successfully"
                : "تم تحديث كلمة المرور الخاصة بك بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
