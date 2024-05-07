using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.MeetingModel;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.SendEmailToUsersInMeeting
{
    public class SendEmailToUsersInMeetingHandler : IRequestHandler<SendEmailToUsersInMeetingCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Meeting> _MeetingRepository;
        private readonly IEmailSender _EmailSender;

        public SendEmailToUsersInMeetingHandler(IAsyncRepository<Meeting> MeetingRepository,
            IEmailSender EmailSender)
        {
            _MeetingRepository = MeetingRepository;
            _EmailSender = EmailSender;
        }

        public async Task<BaseResponse<object>> Handle(SendEmailToUsersInMeetingCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<string> CheckForDuplicatedEmails = Request.UsersInfo
                .GroupBy(m => m.Email.ToLower())
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();

            if (CheckForDuplicatedEmails.Any())
            {
                ResponseMessage = Request.lang == "en"
                    ? $"The following emails are duplicated: {string.Join(", ", CheckForDuplicatedEmails)}"
                    : $"البُرُد الإلكترونية التالية مكررة: {string.Join(", ", CheckForDuplicatedEmails)}";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

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
                List<string> Recipients = Request.UsersInfo.Select(x => x.Email).ToList();

                string EmailSubject = MeetingEntity.ArabicName + "-" + MeetingEntity.EnglishName;

                string FirstArabicLine = $"Meeting Title: {MeetingEntity.ArabicName}";
                string SecondArabicLine = $"Meeting Date: {MeetingEntity.Date.DayOfWeek} " +
                    $"{MeetingEntity.Date.Year}-{MeetingEntity.Date.Month}-{MeetingEntity.Date.Day}";
                string ThirdArabicLine = $"Meeting Time: {MeetingEntity.Date.Hour}:{MeetingEntity.Date} {MeetingEntity.Date.ToString("tt")}";
                string ForthArabicLine = $"Meeting Type: {MeetingEntity.Type}";
                string FifthArabicLine = $"{MeetingEntity.ArabicText}";

                string FirstEnglishLine = $"Meeting Title: {MeetingEntity.EnglishName}";
                string SecondEnglishLine = $"Meeting Date: {MeetingEntity.Date.DayOfWeek} " +
                    $"{MeetingEntity.Date.Year}-{MeetingEntity.Date.Month}-{MeetingEntity.Date.Day}";
                string ThirdEnglishLine = $"Meeting Time: {MeetingEntity.Date.Hour}:{MeetingEntity.Date} {MeetingEntity.Date.ToString("tt")}";
                string ForthEnglishLine = $"Meeting Type: {MeetingEntity.Type}";
                string FifthEnglishLine = $"{MeetingEntity.EnglishText}";

                string EmailArabicBody = (string.IsNullOrEmpty(FifthArabicLine)
                    ? string.Join("\n", FirstArabicLine, SecondArabicLine, ThirdArabicLine, ForthArabicLine)
                    : string.Join("\n", FirstArabicLine, SecondArabicLine, ThirdArabicLine, ForthArabicLine, FifthArabicLine));

                string EmailEnglishBody = (string.IsNullOrEmpty(FifthEnglishLine)
                    ? string.Join("\n", FirstEnglishLine, SecondEnglishLine, ThirdEnglishLine, ForthEnglishLine)
                    : string.Join("\n", FirstEnglishLine, SecondEnglishLine, ThirdEnglishLine, ForthEnglishLine, FifthEnglishLine));

                string FullEmailBody = string.Join("\n", EmailArabicBody, EmailEnglishBody);

                await _EmailSender.SendEmailAsync(Recipients, EmailSubject, FullEmailBody);

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
