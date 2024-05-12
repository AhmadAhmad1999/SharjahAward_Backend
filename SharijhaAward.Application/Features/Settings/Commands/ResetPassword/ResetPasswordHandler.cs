using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.Settings.Commands.ResetPassword
{
    public class ResetPasswordHandler : IRequestHandler<ResetPasswordCommand, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JWTProvider;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;

        public ResetPasswordHandler(IUserRepository UserRepository, 
            IJwtProvider JWTProvider,
            IAsyncRepository<UserToken> UserTokenRepository)
        {
            _UserRepository = UserRepository;
            _JWTProvider = JWTProvider;
            _UserTokenRepository = UserTokenRepository;
        }

        public async Task<BaseResponse<object>> Handle(ResetPasswordCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserID = int.Parse(_JWTProvider.GetUserIdFromToken(Request.Token!));
            
            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository.FirstOrDefaultAsync(x => x.Id == UserID);
            
            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<UserToken> UserTokenEntitiesToDelete = await _UserTokenRepository
                .Where(x => x.UserId == UserID)
                .ToListAsync();

            byte[] salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };
            string NewPasswordAfterHashing = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: Request.NewPassword,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            UserEntity.Password = NewPasswordAfterHashing;

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
                    await _UserTokenRepository.DeleteListAsync(UserTokenEntitiesToDelete);

                    await _UserRepository.UpdateAsync(UserEntity);

                    string Token = _JWTProvider.Generate(UserEntity);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Your password has been updated successfully"
                        : "تم تحديث كلمة المرور الخاصة بك بنجاح";

                    return new BaseResponse<object>(ResponseMessage, true, 200, Token);
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
