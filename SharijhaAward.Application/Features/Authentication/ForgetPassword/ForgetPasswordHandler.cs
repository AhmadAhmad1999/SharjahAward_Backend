using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System.Net.Mail;

namespace SharijhaAward.Application.Features.Authentication.ForgetPassword
{
    internal class ForgetPasswordHandler : IRequestHandler<ForgetPasswordCommand, BaseResponse<int>>
    {
        private readonly IUserRepository _UserRepository;
        private IEmailSender _EmailSender;

        public ForgetPasswordHandler(IUserRepository UserRepository,
            IEmailSender EmailSender)
        {
            _UserRepository = UserRepository;
            _EmailSender = EmailSender;
        }
        public async Task<BaseResponse<int>> Handle(ForgetPasswordCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower());

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Email is not found"
                    : "البريد الإلكتروني غير موجود";

                return new BaseResponse<int>(ResponseMessage, false, 404);
            }

            int ConfirmationCode = new Random().Next(10000, 99999);

            UserEntity.ConfirmationCodeForForgetPassword = ConfirmationCode;

            List<string> Recipients = new List<string>()
            {
                Request.Email
            };

            string EmailSubject = "معلومات الحساب الشخصي" + "-" + "Personal account information";

            string HtmlBody = "wwwroot/ConfirmationCode_Template.html";

            string HTMLContent = File.ReadAllText(HtmlBody);

            byte[] HeaderImageBytes = File.ReadAllBytes("wwwroot/assets/qr/header.png");
            string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

            string FullEmailBody = HTMLContent
                .Replace("$PersonalEmail$", Request.Email)
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

            return new BaseResponse<int>(ResponseMessage, true, 200, UserEntity.Id);
        }
    }
}
