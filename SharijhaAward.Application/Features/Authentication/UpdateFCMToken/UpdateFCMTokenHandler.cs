using MediatR;
using Newtonsoft.Json.Linq;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Authentication.UpdateFCMToken
{
    public class UpdateFCMTokenHandler : IRequestHandler<UpdateFCMTokenCommand, BaseResponse<AuthenticationResponse>>
    {
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;

        public UpdateFCMTokenHandler(IAsyncRepository<UserToken> UserTokenRepository)
        {
            _UserTokenRepository = UserTokenRepository;
        }
        public async Task<BaseResponse<AuthenticationResponse>> Handle(UpdateFCMTokenCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            UserToken? UserTokenEntity = await _UserTokenRepository
                .FirstOrDefaultAsync(x => x.Platform == Request.Platform && 
                    x.Token.ToLower() == Request.token!.ToLower().Replace("Bearer", string.Empty));

            if (UserTokenEntity is null && !string.IsNullOrEmpty(Request.DeviceToken) && !string.IsNullOrWhiteSpace(Request.DeviceToken) &&
                !string.IsNullOrEmpty(Request.token) && !string.IsNullOrWhiteSpace(Request.token))
            {
                UserToken NewUserToken = new UserToken()
                {
                    Token = Request.token!.ToLower().Replace("Bearer", string.Empty),
                    DeviceToken = Request.DeviceToken,
                    Platform = Request.Platform!.Value,
                    AppLanguage = Request.lang!
                };

                await _UserTokenRepository.AddAsync(NewUserToken);

                return new BaseResponse<AuthenticationResponse>(ResponseMessage, true, 200);
            }
            else if (string.IsNullOrEmpty(Request.DeviceToken) || string.IsNullOrWhiteSpace(Request.DeviceToken) ||
                string.IsNullOrEmpty(Request.token) || string.IsNullOrWhiteSpace(Request.token))
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
