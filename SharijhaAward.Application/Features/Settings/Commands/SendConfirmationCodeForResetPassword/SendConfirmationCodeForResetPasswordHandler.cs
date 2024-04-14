using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Models;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.SendConfirmationCodeForResetPassword
{
    public class SendConfirmationCodeForResetPasswordHandler : IRequestHandler<SendConfirmationCodeForResetPasswordCommand,
        BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JWTProvider;
        private IEmailSender _EmailSender;

        public SendConfirmationCodeForResetPasswordHandler(IUserRepository UserRepository,
            IJwtProvider JWTProvider,
            IEmailSender EmailSender)
        {
            _UserRepository = UserRepository;
            _JWTProvider = JWTProvider;
            _EmailSender = EmailSender;
        }
        public async Task<BaseResponse<object>> Handle(SendConfirmationCodeForResetPasswordCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المشترك غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            int ConfirmationCode = new Random().Next(10000, 99999);

            UserEntity.ConfirmationCodeForResetPassword = ConfirmationCode;
            await _UserRepository.UpdateAsync(UserEntity);

            EmailRequest EmailRequest = new EmailRequest()
            {
                ToEmail = UserEntity.Email,
                Subject = Request.lang == "ar"
                    ? $"رمز تفعيل"
                    : "Confirmation Code",
                Body = Request.lang == "ar"
                    ? $"رمز التفعيل الخاص بحسابك: {ConfirmationCode}"
                    : $"This is your account's confirmation code: {ConfirmationCode}"
            };

            await _EmailSender.SendEmailForConfirmationCode(EmailRequest);

            ResponseMessage = Request.lang == "en"
                ? "Confirmation code sent successfuly"
                : "تم إرسال كود التفعيل بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
