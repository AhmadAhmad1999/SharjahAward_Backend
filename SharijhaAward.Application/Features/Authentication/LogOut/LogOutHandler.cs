using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Authentication.LogOut
{
    public class LogOutHandler : IRequestHandler<LogOutCommand,
        BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IJwtProvider _JWTProvider;

        public LogOutHandler(IUserRepository UserRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IJwtProvider JWTProvider)
        {
            _UserRepository = UserRepository;
            _UserTokenRepository = UserTokenRepository;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<object>> Handle(LogOutCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

            UserToken? UserToken = await _UserTokenRepository
                .FirstOrDefaultAsync(x => x.UserId == UserId && x.Token.ToLower() == Request.token!.ToLower().Replace("Bearer", string.Empty) &&
                    x.Platform == Request.Platform);

            if (UserToken is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User's token is not Found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _UserTokenRepository.DeleteAsync(UserToken);

            ResponseMessage = Request.lang == "en"
                ? "Logout operation completed successfully"
                : "تمت عملية تسجيل الخروج بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
