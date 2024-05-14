using MediatR;
using Newtonsoft.Json.Linq;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Authentication.UpdateFCMToken
{
    public class UpdateFCMTokenHandler : IRequestHandler<UpdateFCMTokenCommand, BaseResponse<AuthenticationResponse>>
    {
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IJwtProvider _JWTProvider;

        public UpdateFCMTokenHandler(IAsyncRepository<UserToken> UserTokenRepository,
            IJwtProvider JWTProvider)
        {
            _UserTokenRepository = UserTokenRepository;
            _JWTProvider = JWTProvider;
        }
        public async Task<BaseResponse<AuthenticationResponse>> Handle(UpdateFCMTokenCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

            UserToken? UserTokenEntity = await _UserTokenRepository
                .FirstOrDefaultAsync(x => x.Platform == Request.Platform && 
                    x.Token.ToLower() == Request.token!.ToLower().Replace("bearer ", string.Empty) &&
                    x.UserId == UserId &&
                    ((!string.IsNullOrEmpty(x.DeviceToken))
                        ? x.DeviceToken!.ToLower() == Request.DeviceToken!.ToLower()
                        : true));

            if (UserTokenEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "You must send the token"
                    : "يجب إرسال توكين المستخدم";

                return new BaseResponse<AuthenticationResponse>(ResponseMessage, false, 404);
            }
            
            UserTokenEntity!.DeviceToken = Request.DeviceToken!;

            await _UserTokenRepository.UpdateAsync(UserTokenEntity);

            return new BaseResponse<AuthenticationResponse>(ResponseMessage, true, 200);
        }
    }
}
