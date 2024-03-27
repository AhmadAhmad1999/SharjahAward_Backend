using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.ChangeUserAccountLanguage
{
    public class ChangeUserAccountLanguageHandler : IRequestHandler<ChangeUserAccountLanguageCommand, BaseResponse<object>>
    {
        private IUserRepository _UserRepository;
        private readonly IJwtProvider _JWTProvider;

        public ChangeUserAccountLanguageHandler(IUserRepository UserRepository,
            IJwtProvider JWTProvider)
        {
            _UserRepository = UserRepository;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<object>> Handle(ChangeUserAccountLanguageCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Guid UserID = new Guid(_JWTProvider.GetUserIdFromToken(Request.Token!));

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == UserID);

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User account not found"
                    : "حساب المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            UserEntity.lang = Request.lang;
            await _UserRepository.UpdateAsync(UserEntity);

            ResponseMessage = Request.lang == "en"
                ? "Profile language has been updated successfully"
                : "تم تعديل لغة الحساب الشخصي بنجاح";

            throw new NotImplementedException();
        }
    }
}
