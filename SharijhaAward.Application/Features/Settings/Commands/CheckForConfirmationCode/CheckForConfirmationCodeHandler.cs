using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.CheckForConfirmationCode
{
    public class CheckForConfirmationCodeHandler : IRequestHandler<CheckForConfirmationCodeCommand, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JWTProvider;
        public CheckForConfirmationCodeHandler(IUserRepository UserRepository,
            IJwtProvider JWTProvider)
        {
            _UserRepository = UserRepository;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<object>> Handle(CheckForConfirmationCodeCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Guid UserID = new Guid(_JWTProvider.GetUserIdFromToken(Request.Token));

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository.FirstOrDefaultAsync(x => x.Id == UserID);
            
            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (UserEntity.ConfirmationCodeForResetPassword != Request.ConfirmationCode)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Invalid confirmation code"
                    : "رقم تحقق غير فعال";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
