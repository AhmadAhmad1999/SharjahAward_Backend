using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Settings.Commands.SendConfirmationCodeForResetPassword;
using SharijhaAward.Application.Models;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Authentication.SendConfirmationCodeForSignUp
{
    public class SendConfirmationCodeForSignUpHandler : IRequestHandler<SendConfirmationCodeForSignUpCommand,
        BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private IEmailSender _EmailSender;
        public SendConfirmationCodeForSignUpHandler(IUserRepository UserRepository,
            IEmailSender EmailSender)
        {
            _UserRepository = UserRepository;
            _EmailSender = EmailSender;
        }
        public async Task<BaseResponse<object>> Handle(SendConfirmationCodeForSignUpCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المشترك غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            int ConfirmationCode = new Random().Next(10000, 99999);

            UserEntity.ConfirmationCodeForSignUp = ConfirmationCode;
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
