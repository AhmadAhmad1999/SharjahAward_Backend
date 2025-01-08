using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using System.Globalization;
using System.Net.Http;
using System.Net.Mail;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.CancelInterviewInvitee
{
    public class CancelInterviewInviteeHandler : IRequestHandler<CancelInterviewInviteeCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository;
        private readonly IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository;
        private readonly IEmailSender _EmailSender;

        public CancelInterviewInviteeHandler(IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository,
            IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository,
            IEmailSender _EmailSender)
        {
            this._InterviewInviteeRepository = _InterviewInviteeRepository;
            this._InterviewInviteeParticipantRepository = _InterviewInviteeParticipantRepository;
            this._EmailSender = _EmailSender;
        }

        public async Task<BaseResponse<object>> Handle(CancelInterviewInviteeCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            InterviewInvitee? InterviewInviteeEntity = await _InterviewInviteeRepository
                .FirstOrDefaultAsync(x => x.Id == Request.InterviewInviteeId);

            if (InterviewInviteeEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Interview invitee is not Found"
                    : "الدعوة للمقابلة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<string> Recipients = await _InterviewInviteeParticipantRepository
                .Where(x => x.InterviewInviteeId == Request.InterviewInviteeId)
                .Select(x => !string.IsNullOrEmpty(x.ExternalUserEmail) 
                    ? x.ExternalUserEmail
                    : (x.ArbitratorId != null 
                        ? x.Arbitrator!.Email 
                        : x.Subscriber!.Email))
                .ToListAsync();

            try
            {
                string EmailSubject = "Canceled Interview: " + InterviewInviteeEntity.Interview!.EnglishName + " - " + InterviewInviteeEntity.Interview!.ArabicName + " : المقابلة مُلغى";

                CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                string FirstArabicLine = $"عنوان المقابلة: {InterviewInviteeEntity.Interview!.ArabicName}, رقم الدعوى: {InterviewInviteeEntity.OrderId}";
                string SecondArabicLine = $"تاريخ المقابلة: {InterviewInviteeEntity.StartDate.ToString("dddd", ArabicCulture)}" +
                    $"{InterviewInviteeEntity.StartDate.ToString("d/M/yyyy", ArabicCulture)}";
                string ThirdArabicLine = $"وقت المقابلة: {InterviewInviteeEntity.StartDate.ToString("hh:mm tt", ArabicCulture)}";

                string ForthArabicLine = string.Empty;

                if (InterviewInviteeEntity.Interview!.Type == Domain.Constants.MeetingTypes.Virtual)
                    ForthArabicLine = "نوع المقابلة: افتراضي";
                else
                    ForthArabicLine = "نوع المقابلة: أونلاين";

                string FifthArabicLine = $"نص المقابلة: {InterviewInviteeEntity.Interview!.ArabicText}";
                string SixthArabicLine = $"سبب الإلغاء: {Request.ArabicReasonForCancelling}";

                CultureInfo EnglishCulture = new CultureInfo("en-US");

                string FirstEnglishLine = $"Interview Title: {InterviewInviteeEntity.Interview!.EnglishName}, Invitee Number: {InterviewInviteeEntity.OrderId}";
                string SecondEnglishLine = $"Interview Date: {InterviewInviteeEntity.StartDate.ToString("dddd", EnglishCulture)}" +
                    $"{InterviewInviteeEntity.StartDate.ToString("d/M/yyyy", EnglishCulture)}";
                string ThirdEnglishLine = $"Interview Time: {InterviewInviteeEntity.StartDate.ToString("hh:mm tt", EnglishCulture)}";
                string ForthEnglishLine = $"Interview Type: {InterviewInviteeEntity.Interview!.Type}";
                string FifthEnglishLine = $"Interview Text: {InterviewInviteeEntity.Interview!.EnglishText}";
                string SixthEnglisLine = $"Reason Of Cancelation: {Request.EnglishReasonForCancelling}";

                string HTMLContent = await File.ReadAllTextAsync(Request.WWWRootFilePath + "/Send_Email_Template.html");

                var Spliter = HTMLContent.Split("<!--MeetingLink-->");
                HTMLContent = Spliter[0] + Spliter[2];

                byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath + "/assets/qr/header.png");
                string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                string FullEmailBody = HTMLContent
                    .Replace("$FirstArabicLine$",   FirstArabicLine,   StringComparison.Ordinal)
                    .Replace("$SecondArabicLine$",  SecondArabicLine,  StringComparison.Ordinal)
                    .Replace("$ThirdArabicLine$",   ThirdArabicLine,   StringComparison.Ordinal)
                    .Replace("$ForthArabicLine$",   ForthArabicLine,   StringComparison.Ordinal)
                    .Replace("$FifthArabicLine$",   FifthArabicLine,   StringComparison.Ordinal)
                    .Replace("$SixthArabicLine$",   SixthArabicLine,   StringComparison.Ordinal)
                    .Replace("$FirstEnglishLine$",  FirstEnglishLine,  StringComparison.Ordinal)
                    .Replace("$SecondEnglishLine$", SecondEnglishLine, StringComparison.Ordinal)
                    .Replace("$ThirdEnglishLine$",  ThirdEnglishLine,  StringComparison.Ordinal)
                    .Replace("$ForthEnglishLine$",  ForthEnglishLine,  StringComparison.Ordinal)
                    .Replace("$FifthEnglishLine$",  FifthEnglishLine,  StringComparison.Ordinal)
                    .Replace("$SixthEnglisLine$",   SixthEnglisLine,   StringComparison.Ordinal);

                // Create An AlternateView to Specify The HTML Body And Embed The Image..
                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(FullEmailBody, null, "text/html");

                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                AlternateView.LinkedResources.Add(HeaderImage);

                FullEmailBody = FullEmailBody
                    .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                await _EmailSender.SendEmailAsync(Recipients, EmailSubject, FullEmailBody, AlternateView);

                ResponseMessage = Request.lang == "en"
                    ? "The interview was successfully cancelled, and emails were sent to its participants"
                    : "تم إلغاء المقابلة بنجاح، وتم إرسال رسائل البريد الإلكتروني إلى المشاركين فيها";

                InterviewInviteeEntity.isCancelled = true;
                InterviewInviteeEntity.EnglishReasonForCancelling = Request.EnglishReasonForCancelling;
                InterviewInviteeEntity.ArabicReasonForCancelling = Request.ArabicReasonForCancelling;

                await _InterviewInviteeRepository.UpdateAsync(InterviewInviteeEntity);

                return new BaseResponse<object>(ResponseMessage, true, 200);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
