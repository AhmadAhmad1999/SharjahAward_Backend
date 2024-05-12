using MediatR;
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
                .FirstOrDefaultAsync(x => x.Platform == Request.Platform && x.Token.ToLower() == Request.token!.ToLower());

            if (UserTokenEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not Found"
                    : "المستخدم غير موجود";

                return new BaseResponse<AuthenticationResponse>(ResponseMessage, false, 404);
            }

            UserTokenEntity.DeviceToken = Request.DeviceToken!;

            await _UserTokenRepository.UpdateAsync(UserTokenEntity);

            return new BaseResponse<AuthenticationResponse>(ResponseMessage, true, 200);
        }
    }
}
