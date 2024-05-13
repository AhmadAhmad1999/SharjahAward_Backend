using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Settings.Commands.ChangeUserAccountLanguage
{
    public class ChangeUserAccountLanguageHandler : IRequestHandler<ChangeUserAccountLanguageCommand, BaseResponse<object>>
    {
        private IUserRepository _UserRepository;
        private readonly IJwtProvider _JWTProvider;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;

        public ChangeUserAccountLanguageHandler(IUserRepository UserRepository,
            IJwtProvider JWTProvider,
            IAsyncRepository<UserToken> UserTokenRepository)
        {
            _UserRepository = UserRepository;
            _JWTProvider = JWTProvider;
            _UserTokenRepository = UserTokenRepository;
        }

        public async Task<BaseResponse<object>> Handle(ChangeUserAccountLanguageCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserID = int.Parse(_JWTProvider.GetUserIdFromToken(Request.Token!));

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == UserID);

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User account not found"
                    : "حساب المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            UserToken? UserTokenEntity = await _UserTokenRepository
                .FirstOrDefaultAsync(x => x.UserId == UserID && 
                    ((!string.IsNullOrEmpty(x.DeviceToken) && !string.IsNullOrEmpty(Request.DeviceToken)) 
                        ? x.DeviceToken.ToLower() == Request.DeviceToken!.ToLower() 
                        : true) &&
                    x.Token.ToLower() == Request.Token!.ToLower().Replace("Bearer", string.Empty));

            if (UserTokenEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User token is not found"
                    : "حساب المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            UserTokenEntity.AppLanguage = Request.NewLanguage;

            await _UserTokenRepository.UpdateAsync(UserTokenEntity);

            ResponseMessage = Request.lang == "en"
                ? "Profile language has been updated successfully"
                : "تم تعديل لغة الحساب الشخصي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
