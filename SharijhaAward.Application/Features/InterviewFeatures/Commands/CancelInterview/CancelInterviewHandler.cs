using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using System.Globalization;
using System.Net.Mail;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.CancelInterview
{
    public class CancelInterviewHandler : IRequestHandler<CancelInterviewCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<InterviewUser> _InterviewUserRepository;
        private readonly IEmailSender _EmailSender;

        public CancelInterviewHandler(IAsyncRepository<Interview> InterviewRepository,
            IAsyncRepository<InterviewUser> InterviewUserRepository,
            IEmailSender EmailSender)
        {
            _InterviewRepository = InterviewRepository;
            _InterviewUserRepository = InterviewUserRepository;
            _EmailSender = EmailSender;
        }

        public async Task<BaseResponse<object>> Handle(CancelInterviewCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Interview? InterviewEntity = await _InterviewRepository
                .FirstOrDefaultAsync(x => x.Id == Request.InterviewId);

            if (InterviewEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Interview is not Found"
                    : "المقابلة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<string> Recipients = await _InterviewUserRepository
                .Where(x => x.InterviewId == Request.InterviewId)
                .Select(x => x.Email)
                .ToListAsync();

            try
            {
                string EmailSubject = "Canceled Interview: " + InterviewEntity.EnglishName + " - " + InterviewEntity.ArabicName + " : المقابلة مُلغى";

                CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                string FirstArabicLine = $"عنوان المقابلة: {InterviewEntity.ArabicName}";
                string SecondArabicLine = $"تاريخ المقابلة: {InterviewEntity.StartDate.ToString("dddd", ArabicCulture)}" +
                    $"{InterviewEntity.StartDate.ToString("d/M/yyyy", ArabicCulture)}";
                string ThirdArabicLine = $"وقت المقابلة: {InterviewEntity.StartDate.ToString("hh:mm tt", ArabicCulture)}";

                string ForthArabicLine = string.Empty;

                if (InterviewEntity.Type == Domain.Constants.MeetingTypes.Virtual)
                    ForthArabicLine = "نوع المقابلة: افتراضي";
                else
                    ForthArabicLine = "نوع المقابلة: أونلاين";

                string FifthArabicLine = $"نص المقابلة: {InterviewEntity.ArabicText}";
                string SixthArabicLine = $"سبب الإلغاء: {Request.ArabicReasonOfCanceling}";

                CultureInfo EnglishCulture = new CultureInfo("en-US");

                string FirstEnglishLine = $"Interview Title: {InterviewEntity.EnglishName}";
                string SecondEnglishLine = $"Interview Date: {InterviewEntity.StartDate.ToString("dddd", EnglishCulture)}" +
                    $"{InterviewEntity.StartDate.ToString("d/M/yyyy", EnglishCulture)}";
                string ThirdEnglishLine = $"Interview Time: {InterviewEntity.StartDate.ToString("hh:mm tt", EnglishCulture)}";
                string ForthEnglishLine = $"Interview Type: {InterviewEntity.Type}";
                string FifthEnglishLine = $"Interview Text: {InterviewEntity.EnglishText}";
                string SixthEnglisLine = $"Reason Of Cancelation: {Request.EnglishReasonOfCanceling}";

                string HtmlBody = "wwwroot/Send_Email_Template.html";

                string HTMLContent = File.ReadAllText(HtmlBody);

                byte[] HeaderImageBytes = File.ReadAllBytes("wwwroot/assets/qr/header.png");
                string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                string FullEmailBody = HTMLContent
                    .Replace("$FirstArabicLine$", FirstArabicLine, StringComparison.Ordinal)
                    .Replace("$SecondArabicLine$", SecondArabicLine, StringComparison.Ordinal)
                    .Replace("$ThirdArabicLine$", ThirdArabicLine, StringComparison.Ordinal)
                    .Replace("$ForthArabicLine$", ForthArabicLine, StringComparison.Ordinal)
                    .Replace("$FifthArabicLine$", FifthArabicLine, StringComparison.Ordinal)
                    .Replace("$SixthArabicLine$", SixthArabicLine, StringComparison.Ordinal)
                    .Replace("$FirstEnglishLine$", FirstEnglishLine, StringComparison.Ordinal)
                    .Replace("$SecondEnglishLine$", SecondEnglishLine, StringComparison.Ordinal)
                    .Replace("$ThirdEnglishLine$", ThirdEnglishLine, StringComparison.Ordinal)
                    .Replace("$ForthEnglishLine$", ForthEnglishLine, StringComparison.Ordinal)
                    .Replace("$FifthEnglishLine$", FifthEnglishLine, StringComparison.Ordinal)
                    .Replace("$SixthEnglisLine$", SixthEnglisLine, StringComparison.Ordinal);

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

                InterviewEntity.isCanceled = true;
                InterviewEntity.EnglishReasonOfCanceling = Request.EnglishReasonOfCanceling;
                InterviewEntity.ArabicReasonOfCanceling = Request.ArabicReasonOfCanceling;

                await _InterviewRepository.UpdateAsync(InterviewEntity);

                return new BaseResponse<object>(ResponseMessage, true, 200);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
