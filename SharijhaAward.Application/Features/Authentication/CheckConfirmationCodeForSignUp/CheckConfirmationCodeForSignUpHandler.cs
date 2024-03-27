using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Authentication.Login;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Authentication.CheckConfirmationCodeForSignUp
{
    internal class CheckConfirmationCodeForSignUpHandler : IRequestHandler<CheckConfirmationCodeForSignUpCommand, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JWTProvider;
        private readonly IMapper _Mapper;

        public CheckConfirmationCodeForSignUpHandler(IUserRepository UserRepository,
            IJwtProvider JWTProvider,
            IMapper Mapper)
        {
            _UserRepository = UserRepository;
            _JWTProvider = JWTProvider;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(CheckConfirmationCodeForSignUpCommand Request, CancellationToken cancellationToken)
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

            if (UserEntity.ConfirmationCodeForSignUp != Request.ConfirmationCode)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Invalid confirmation code"
                    : "رقم تحقق غير فعال";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            Domain.Entities.IdentityModels.User? CheckIfEmailIsAlreadyUsed = await _UserRepository
                .FirstOrDefaultAsync(x => x.isValidAccount && x.Email.ToLower() == UserEntity.Email.ToLower() &&
                    x.Id != UserEntity.Id);

            if (CheckIfEmailIsAlreadyUsed != null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This email is already used"
                    : "البريد الإلكتروني مستخدم مسبقاً";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            UserEntity.ConfirmationCodeForSignUp = null;
            UserEntity.isValidAccount = true;

            await _UserRepository.UpdateAsync(UserEntity);

            string Token = _JWTProvider.Generate(UserEntity);

            AuthenticationResponse Response = new AuthenticationResponse()
            {
                token = Token,
                user = _Mapper.Map<UserDataResponse>(UserEntity),
                message = "Account confirmed successfully",
                isSucceed = true,
                permissions = null
            };

            return new BaseResponse<object>(ResponseMessage, true, 200, Response);
        }
    }
}
