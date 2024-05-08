using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.MeetingModel;
using SharijhaAward.Domain.Entities.MeetingUserModel;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.CancelMeeting
{
    public class CancelMeetingHandler : IRequestHandler<CancelMeetingCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Meeting> _MeetingRepository;
        private readonly IAsyncRepository<MeetingUser> _MeetingUserRepository;
        private readonly IEmailSender _EmailSender;

        public CancelMeetingHandler(IAsyncRepository<Meeting> MeetingRepository,
            IAsyncRepository<MeetingUser> MeetingUserRepository,
            IEmailSender EmailSender)
        {
            _MeetingRepository = MeetingRepository;
            _MeetingUserRepository = MeetingUserRepository;
            _EmailSender = EmailSender;
        }

        public async Task<BaseResponse<object>> Handle(CancelMeetingCommand Request, CancellationToken cancellationToken)
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

            List<string> Recipients = await _MeetingUserRepository
                .Where(x => x.MeetingId == Request.MeetingId)
                .Select(x => x.Email)
                .ToListAsync();

            try
            {
                string EmailSubject = "Canceled Meeting: " + MeetingEntity.EnglishName + " - اجتماع مُلغى: " + MeetingEntity.ArabicName;

                string FirstArabicLine = $"عنوان الاجتماع: {MeetingEntity.ArabicName}";
                string SecondArabicLine = $"تاريخ الاجتماع: {MeetingEntity.Date.DayOfWeek} " +
                    $"{MeetingEntity.Date.Year}-{MeetingEntity.Date.Month}-{MeetingEntity.Date.Day}";
                string ThirdArabicLine = $"وقت الاجتماع: {MeetingEntity.Date.Hour}:{MeetingEntity.Date} {MeetingEntity.Date.ToString("tt")}";
                string ForthArabicLine = $"نوع الاجتماع: {MeetingEntity.Type}";
                string FifthArabicLine = $"{MeetingEntity.ArabicText}";
                string SixthArabicLine = $"سبب الإلغاء: {Request.ArabicReasonOfCanceling}";

                string FirstEnglishLine = $"Meeting Title: {MeetingEntity.EnglishName}";
                string SecondEnglishLine = $"Meeting Date: {MeetingEntity.Date.DayOfWeek} " +
                    $"{MeetingEntity.Date.Year}-{MeetingEntity.Date.Month}-{MeetingEntity.Date.Day}";
                string ThirdEnglishLine = $"Meeting Time: {MeetingEntity.Date.Hour}:{MeetingEntity.Date} {MeetingEntity.Date.ToString("tt")}";
                string ForthEnglishLine = $"Meeting Type: {MeetingEntity.Type}";
                string FifthEnglishLine = $"{MeetingEntity.EnglishText}";
                string SixthEnglisLine = $"Reason Of Canceling: {Request.EnglishReasonOfCanceling}";

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
                    : "The meeting was successfully cancelled, and emails were sent to its participants";

                MeetingEntity.isCanceled = true;
                await _MeetingRepository.UpdateAsync(MeetingEntity);

                return new BaseResponse<object>(ResponseMessage, true, 200);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
