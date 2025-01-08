using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Models;
using SharijhaAward.Application.Responses;
using System.Net.Http;
using System.Net.Mail;

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

            List<string> Recipients = new List<string>()
            {
                UserEntity.Email
            };

            string EmailSubject = "معلومات الحساب الشخصي" + "-" + "Personal account information";

            string HTMLContent = await File.ReadAllTextAsync(Request.WWWRootFilePath + "/ConfirmationCode_Template.html");

            byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath + "/assets/qr/header.png");
            string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

            string FullEmailBody = HTMLContent
                .Replace("$PersonalEmail$", UserEntity.Email)
                .Replace("$ConfirmationCode$", ConfirmationCode.ToString());

            // Create An AlternateView to Specify The HTML Body And Embed The Image..
            AlternateView AlternateView2 = AlternateView.CreateAlternateViewFromString(FullEmailBody, null, "text/html");

            LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
            AlternateView2.LinkedResources.Add(HeaderImage);

            FullEmailBody = FullEmailBody
                .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

            await _EmailSender.SendEmailAsync(Recipients, EmailSubject, FullEmailBody, AlternateView2);

            ResponseMessage = Request.lang == "en"
                ? "Confirmation code sent successfuly"
                : "تم إرسال كود التفعيل بنجاح";

            await _UserRepository.UpdateAsync(UserEntity);

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
