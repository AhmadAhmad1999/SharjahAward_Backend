using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.UserFeatures.Commands.ChangePassword
{
    public class ChangePasswordHandler : IRequestHandler<ChangePasswordCommand, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IJwtProvider _JWTProvider;

        public ChangePasswordHandler(IUserRepository UserRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IJwtProvider JWTProvider)
        {
            _UserRepository = UserRepository;
            _UserTokenRepository = UserTokenRepository;
            _JWTProvider = JWTProvider;
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

            List<UserToken> UserTokenEntitiesToDelete = await _UserTokenRepository
                .Where(x => x.UserId == UserEntity.Id)
                .ToListAsync();

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
                    await _UserRepository.UpdateAsync(UserEntity);

                    await _UserTokenRepository.DeleteListAsync(UserTokenEntitiesToDelete);

                    string Token = _JWTProvider.Generate(UserEntity);

                    UserToken NewUserTokenEntity = new UserToken()
                    {
                        UserId = UserEntity.Id,
                        Token = Token
                    };

                    await _UserTokenRepository.AddAsync(NewUserTokenEntity);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "User's password has been updated successfully"
                        : "تم تعديل كلمة مرور المستخدم بنجاح";

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
