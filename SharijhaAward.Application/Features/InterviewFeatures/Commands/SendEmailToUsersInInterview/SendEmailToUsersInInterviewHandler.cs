using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using System.Globalization;
using System.Net.Http;
using System.Net.Mail;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.SendEmailToUsersInInterview
{
    public class SendEmailToUsersInInterviewHandler : IRequestHandler<SendEmailToUsersInInterviewCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository;
        private readonly IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository;
        private readonly IEmailSender _EmailSender;

        public SendEmailToUsersInInterviewHandler(IAsyncRepository<Interview> _InterviewRepository,
            IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository,
            IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository,
            IEmailSender _EmailSender)
        {
            this._InterviewRepository = _InterviewRepository;
            this._InterviewInviteeRepository = _InterviewInviteeRepository;
            this._InterviewInviteeParticipantRepository = _InterviewInviteeParticipantRepository;
            this._EmailSender = _EmailSender;
        }

        public async Task<BaseResponse<object>> Handle(SendEmailToUsersInInterviewCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.InterviewId is not null)
            {
                Interview? InterviewEntity = await _InterviewRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.InterviewId);

                if (InterviewEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Interview is not Found"
                        : "المقابلة غير موجود";

                    return new BaseResponse<object>(ResponseMessage, false, 404);
                }

                try
                {
                    List<string> Recipients = await _InterviewInviteeParticipantRepository.Where(x => x.InterviewInvitee!.InterviewId == Request.InterviewId)
                        .Select(x => !string.IsNullOrEmpty(x.ExternalUserEmail)
                            ? x.ExternalUserEmail
                            : (x.ArbitratorId != null
                                ? x.Arbitrator!.Email
                                : x.Subscriber!.Email)).ToListAsync();

                    string EmailSubject = InterviewEntity.ArabicName + "-" + InterviewEntity.EnglishName;

                    CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                    string FirstArabicLine = $"عنوان المقابلة: {InterviewEntity.ArabicName}";
                    string SecondArabicLine = $"تاريخ المقابلة: {InterviewEntity.StartDate.ToString("dddd", ArabicCulture)}" +
                        $"{InterviewEntity.StartDate.ToString("d/M/yyyy", ArabicCulture)}";
                    string ThirdArabicLine = $"وقت المقابلة: {InterviewEntity.StartDate.ToString("hh:mm tt", ArabicCulture)}";

                    string ForthArabicLine = string.Empty;

                    if (InterviewEntity.Type == Domain.Constants.MeetingTypes.Virtual)
                        ForthArabicLine = "نوع المقابلة: أونلاين";
                    else
                        ForthArabicLine = $"نوع المقابلة: في الموقع, موقع المقابلة: {InterviewEntity.Address}";

                    string FifthArabicLine = $"نص المقابلة: {InterviewEntity.ArabicText}";

                    CultureInfo EnglishCulture = new CultureInfo("en-US");

                    string FirstEnglishLine = $"Interview Title: {InterviewEntity.EnglishName}";
                    string SecondEnglishLine = $"Interview Date: {InterviewEntity.StartDate.ToString("dddd", EnglishCulture)}" +
                        $"{InterviewEntity.StartDate.ToString("d/M/yyyy", EnglishCulture)}";
                    string ThirdEnglishLine = $"Interview Time: {InterviewEntity.StartDate.ToString("hh:mm tt", EnglishCulture)}";

                    string ForthEnglishLine = string.Empty;

                    if (InterviewEntity.Type == Domain.Constants.MeetingTypes.Virtual)
                        ForthEnglishLine = $"Interview Type: {InterviewEntity.Type}";
                    else
                        ForthEnglishLine = $"Interview Type: {InterviewEntity.Type}, Interview Address: {InterviewEntity.Address}";

                    string FifthEnglishLine = $"Interview Text: {InterviewEntity.EnglishText}";

                    string HTMLContent = await File.ReadAllTextAsync(Request.WWWRootFilePath + "/Send_Email_Template.html");

                    byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath + "/assets/qr/header.png");
                    string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

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
                        .Replace("$SixthEnglisLine$", "", StringComparison.Ordinal);

                    // Create An AlternateView to Specify The HTML Body And Embed The Image..
                    AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(FullEmailBody, null, "text/html");

                    LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                    AlternateView.LinkedResources.Add(HeaderImage);

                    FullEmailBody = FullEmailBody
                        .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                    await _EmailSender.SendEmailAsync(Recipients, EmailSubject, FullEmailBody, AlternateView);

                    ResponseMessage = Request.lang == "en"
                        ? "Sent successfully"
                        : "تم إرسال إيميلات الدعوة للمقابلة بنجاح";

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else if (Request.InterviewInviteeId is not null)
            {
                InterviewInvitee? InterviewInviteeEntity = await _InterviewInviteeRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.InterviewInviteeId);

                if (InterviewInviteeEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Interview invitee is not Found"
                        : "الدعوة للمقابلة غير موجودة";

                    return new BaseResponse<object>(ResponseMessage, false, 404);
                }

                Interview InterviewEntity = InterviewInviteeEntity.Interview!;

                try
                {
                    List<string> Recipients = await _InterviewInviteeParticipantRepository.Where(x => x.InterviewInviteeId == Request.InterviewInviteeId)
                        .Select(x => !string.IsNullOrEmpty(x.ExternalUserEmail)
                            ? x.ExternalUserEmail
                            : (x.ArbitratorId != null
                                ? x.Arbitrator!.Email
                                : x.Subscriber!.Email)).ToListAsync();

                    string EmailSubject = InterviewEntity.ArabicName + "-" + InterviewEntity.EnglishName;

                    CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                    string FirstArabicLine = $"عنوان المقابلة: {InterviewEntity.ArabicName}, رقم الدعوة: {InterviewInviteeEntity.OrderId}";
                    string SecondArabicLine = $"تاريخ المقابلة: {InterviewEntity.StartDate.ToString("dddd", ArabicCulture)}" +
                        $"{InterviewEntity.StartDate.ToString("d/M/yyyy", ArabicCulture)}";
                    string ThirdArabicLine = $"وقت المقابلة: {InterviewEntity.StartDate.ToString("hh:mm tt", ArabicCulture)}";

                    string ForthArabicLine = string.Empty;

                    if (InterviewEntity.Type == Domain.Constants.MeetingTypes.Virtual)
                        ForthArabicLine = "نوع المقابلة: أونلاين";
                    else
                        ForthArabicLine = $"نوع المقابلة: في الموقع, موقع المقابلة: {InterviewEntity.Address}";

                    string FifthArabicLine = $"نص المقابلة: {InterviewEntity.ArabicText}";

                    CultureInfo EnglishCulture = new CultureInfo("en-US");

                    string FirstEnglishLine = $"Interview Title: {InterviewEntity.EnglishName}, Invitee Number: {InterviewInviteeEntity.OrderId}";
                    string SecondEnglishLine = $"Interview Date: {InterviewEntity.StartDate.ToString("dddd", EnglishCulture)}" +
                        $"{InterviewEntity.StartDate.ToString("d/M/yyyy", EnglishCulture)}";
                    string ThirdEnglishLine = $"Interview Time: {InterviewEntity.StartDate.ToString("hh:mm tt", EnglishCulture)}";

                    string ForthEnglishLine = string.Empty;

                    if (InterviewEntity.Type == Domain.Constants.MeetingTypes.Virtual)
                        ForthEnglishLine = $"Interview Type: {InterviewEntity.Type}";
                    else
                        ForthEnglishLine = $"Interview Type: {InterviewEntity.Type}, Interview Address: {InterviewEntity.Address}";

                    string FifthEnglishLine = $"Interview Text: {InterviewEntity.EnglishText}";

                    string HTMLContent = await File.ReadAllTextAsync(Request.WWWRootFilePath + "/Send_Email_Template.html");

                    byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath + "/assets/qr/header.png");
                    string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

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
                        .Replace("$SixthEnglisLine$", "", StringComparison.Ordinal);

                    // Create An AlternateView to Specify The HTML Body And Embed The Image..
                    AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(FullEmailBody, null, "text/html");

                    LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                    AlternateView.LinkedResources.Add(HeaderImage);

                    FullEmailBody = FullEmailBody
                        .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                    await _EmailSender.SendEmailAsync(Recipients, EmailSubject, FullEmailBody, AlternateView);

                    ResponseMessage = Request.lang == "en"
                        ? "Sent successfully"
                        : "تم إرسال إيميلات الدعوة للمقابلة بنجاح";

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                ResponseMessage = Request.lang == "en"
                    ? "You must send on of the requested Ids"
                    : "يجب إرسال إحدى المعرفات";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }
        }
    }
}
