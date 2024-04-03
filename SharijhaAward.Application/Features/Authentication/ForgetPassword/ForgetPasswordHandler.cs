using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Models;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Authentication.ForgetPassword
{
    internal class ForgetPasswordHandler : IRequestHandler<ForgetPasswordCommand, BaseResponse<Guid>>
    {
        private readonly IUserRepository _UserRepository;
        private IEmailSender _EmailSender;

        public ForgetPasswordHandler(IUserRepository UserRepository,
            IEmailSender EmailSender)
        {
            _UserRepository = UserRepository;
            _EmailSender = EmailSender;
        }
        public async Task<BaseResponse<Guid>> Handle(ForgetPasswordCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower());

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Email is not found"
                    : "البريد الإلكتروني غير موجود";

                return new BaseResponse<Guid>(ResponseMessage, false, 404);
            }

            int ConfirmationCode = new Random().Next(10000, 99999);

            UserEntity.ConfirmationCodeForForgetPassword = ConfirmationCode;
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

            return new BaseResponse<Guid>(ResponseMessage, true, 200, UserEntity.Id);
        }
    }
}
