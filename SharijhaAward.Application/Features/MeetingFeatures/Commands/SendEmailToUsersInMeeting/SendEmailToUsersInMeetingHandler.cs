using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.MeetingModel;
using SharijhaAward.Domain.Entities.MeetingUserModel;
using System.Globalization;
using System.Net.Mail;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.SendEmailToUsersInMeeting
{
    public class SendEmailToUsersInMeetingHandler : IRequestHandler<SendEmailToUsersInMeetingCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Meeting> _MeetingRepository;
        private readonly IAsyncRepository<MeetingUser> _MeetingUserRepository;
        private readonly IEmailSender _EmailSender;

        public SendEmailToUsersInMeetingHandler(IAsyncRepository<Meeting> MeetingRepository,
            IAsyncRepository<MeetingUser> MeetingUserRepository,
            IEmailSender EmailSender)
        {
            _MeetingRepository = MeetingRepository;
            _MeetingUserRepository = MeetingUserRepository;
            _EmailSender = EmailSender;
        }

        public async Task<BaseResponse<object>> Handle(SendEmailToUsersInMeetingCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Meeting? MeetingEntity = await _MeetingRepository
                .FirstOrDefaultAsync(x => x.Id == Request.MeetingId);

            if (MeetingEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Meeting is not Found"
                    : "الاجتماع غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            try
            {
                List<string> Recipients = await _MeetingUserRepository.Where(x => x.MeetingId == Request.MeetingId)
                    .Select(x => x.Email).ToListAsync();

                string EmailSubject = MeetingEntity.ArabicName + "-" + MeetingEntity.EnglishName;

                CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                string FirstArabicLine = $"عنوان الاجتماع: {MeetingEntity.ArabicName}";
                string SecondArabicLine = $"تاريخ الاجتماع: {MeetingEntity.Date.ToString("dddd", ArabicCulture)}" +
                    $"{MeetingEntity.Date.ToString("d/M/yyyy", ArabicCulture)}";
                string ThirdArabicLine = $"وقت الاجتماع: {MeetingEntity.Date.ToString("hh:mm tt", ArabicCulture)}";

                string ForthArabicLine = string.Empty;

                if (MeetingEntity.Type == Domain.Constants.MeetingTypes.Virtual)
                    ForthArabicLine = "نوع الاجتماع: افتراضي";
                else
                    ForthArabicLine = "نوع الاجتماع: أونلاين";

                string FifthArabicLine = $"نص الاجتماع: {MeetingEntity.ArabicText}";

                CultureInfo EnglishCulture = new CultureInfo("en-US");

                string FirstEnglishLine = $"Meeting Title: {MeetingEntity.EnglishName}";
                string SecondEnglishLine = $"Meeting Date: {MeetingEntity.Date.ToString("dddd", EnglishCulture)}" +
                    $"{MeetingEntity.Date.ToString("d/M/yyyy", EnglishCulture)}";
                string ThirdEnglishLine = $"Meeting Time: {MeetingEntity.Date.ToString("hh:mm tt", EnglishCulture)}";
                string ForthEnglishLine = $"Meeting Type: {MeetingEntity.Type}";
                string FifthEnglishLine = $"Meeting Text: {MeetingEntity.EnglishText}";

                string MeetingLink = $"Meeting Link: {MeetingEntity.MeetingLink}";

                string HtmlBody = "wwwroot/Send_Email_Template.html";

                string HTMLContent = File.ReadAllText(HtmlBody);

                byte[] HeaderImageBytes = File.ReadAllBytes("wwwroot/assets/qr/header.png");
                string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                if (string.IsNullOrEmpty(MeetingEntity.MeetingLink))
                {
                    string[]? HtmlBodySpliter = HtmlBody.Split("<!--MeetingLink-->");

                    HtmlBody = HtmlBodySpliter[0] + HtmlBodySpliter[2];
                }

                string FullEmailBody = HTMLContent
                    .Replace("$FirstArabicLine$", FirstArabicLine, StringComparison.Ordinal)
                    .Replace("$SecondArabicLine$", SecondArabicLine, StringComparison.Ordinal)
                    .Replace("$ThirdArabicLine$", ThirdArabicLine, StringComparison.Ordinal)
                    .Replace("$ForthArabicLine$", ForthArabicLine, StringComparison.Ordinal)
                    .Replace("$FifthArabicLine$", FifthArabicLine, StringComparison.Ordinal)
                    .Replace("$FirstEnglishLine$", FirstEnglishLine, StringComparison.Ordinal)
                    .Replace("$SecondEnglishLine$", SecondEnglishLine, StringComparison.Ordinal)
                    .Replace("$ThirdEnglishLine$", ThirdEnglishLine, StringComparison.Ordinal)
                    .Replace("$ForthEnglishLine$", ForthEnglishLine, StringComparison.Ordinal)
                    .Replace("$FifthEnglishLine$", FifthEnglishLine, StringComparison.Ordinal)
                    .Replace("$SixthArabicLine$", "", StringComparison.Ordinal)
                    .Replace("$SixthEnglisLine$", "", StringComparison.Ordinal)
                    .Replace("$MeetingLink$", "", StringComparison.Ordinal);

                // Create An AlternateView to Specify The HTML Body And Embed The Image..
                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(FullEmailBody, null, "text/html");

                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                AlternateView.LinkedResources.Add(HeaderImage);

                FullEmailBody = FullEmailBody
                    .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                await _EmailSender.SendEmailAsync(Recipients, EmailSubject, FullEmailBody, AlternateView);

                ResponseMessage = Request.lang == "en"
                    ? "Sent successfully"
                    : "تم إرسال إيميلات الدعوة للاجتماع بنجاح";

                return new BaseResponse<object>(ResponseMessage, true, 200);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
