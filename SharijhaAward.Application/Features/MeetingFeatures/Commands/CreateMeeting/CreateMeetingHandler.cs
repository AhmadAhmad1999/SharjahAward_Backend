using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.MeetingCategoryModel;
using SharijhaAward.Domain.Entities.MeetingModel;
using SharijhaAward.Domain.Entities.MeetingUserModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.CreateMeeting
{
    public class CreateMeetingHandler : IRequestHandler<CreateMeetingCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Meeting> _MeetingRepository;
        private readonly IAsyncRepository<MeetingUser> _MeetingUserRepository;
        private readonly IAsyncRepository<MeetingCategory> _MeetingCategoryRepository;
        private readonly IEmailSender _EmailSender;

        public CreateMeetingHandler(IMapper Mapper,
            IAsyncRepository<Meeting> MeetingRepository,
            IAsyncRepository<MeetingUser> MeetingUserRepository,
            IAsyncRepository<MeetingCategory> MeetingCategoryRepository,
            IEmailSender EmailSender)
        {
            _Mapper = Mapper;
            _MeetingRepository = MeetingRepository;
            _MeetingUserRepository = MeetingUserRepository;
            _MeetingCategoryRepository = MeetingCategoryRepository;
            _EmailSender = EmailSender;
        }
        public async Task<BaseResponse<object>> Handle(CreateMeetingCommand Request, CancellationToken cancellationToken)
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

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    Meeting NewMeetingEntity = _Mapper.Map<Meeting>(Request);

                    await _MeetingRepository.AddAsync(NewMeetingEntity);

                    List<MeetingUser> NewMeetingUserEntities = Request.UsersInfo
                        .Select(x => new MeetingUser()
                        {
                            Name = x.Name,
                            Email = x.Email,
                            MeetingId = NewMeetingEntity.Id
                        }).ToList();

                    await _MeetingUserRepository.AddRangeAsync(NewMeetingUserEntities);

                    List<MeetingCategory> NewMeetingCategoryEntities = Request.CategoriesIds
                        .Select(x => new MeetingCategory()
                        {
                            CategoryId = x,
                            MeetingId = NewMeetingEntity.Id
                        }).ToList();

                    await _MeetingCategoryRepository.AddRangeAsync(NewMeetingCategoryEntities);

                    List<string> Recipients = Request.UsersInfo.Select(x => x.Email).ToList();

                    string EmailSubject = NewMeetingEntity.ArabicName + "-" + NewMeetingEntity.EnglishName;

                    string FirstArabicLine = $"Meeting Title: {NewMeetingEntity.ArabicName}";
                    string SecondArabicLine = $"Meeting Date: {NewMeetingEntity.Date.DayOfWeek} " +
                        $"{NewMeetingEntity.Date.Year}-{NewMeetingEntity.Date.Month}-{NewMeetingEntity.Date.Day}";
                    string ThirdArabicLine = $"Meeting Time: {NewMeetingEntity.Date.Hour}:{NewMeetingEntity.Date} {NewMeetingEntity.Date.ToString("tt")}";
                    string ForthArabicLine = $"Meeting Type: {NewMeetingEntity.Type}";
                    string FifthArabicLine = $"{NewMeetingEntity.ArabicText}";

                    string FirstEnglishLine = $"Meeting Title: {NewMeetingEntity.EnglishName}";
                    string SecondEnglishLine = $"Meeting Date: {NewMeetingEntity.Date.DayOfWeek} " +
                        $"{NewMeetingEntity.Date.Year}-{NewMeetingEntity.Date.Month}-{NewMeetingEntity.Date.Day}";
                    string ThirdEnglishLine = $"Meeting Time: {NewMeetingEntity.Date.Hour}:{NewMeetingEntity.Date} {NewMeetingEntity.Date.ToString("tt")}";
                    string ForthEnglishLine = $"Meeting Type: {NewMeetingEntity.Type}";
                    string FifthEnglishLine = $"{NewMeetingEntity.EnglishText}";

                    string EmailArabicBody = (string.IsNullOrEmpty(FifthArabicLine)
                        ? string.Join("\n", FirstArabicLine, SecondArabicLine, ThirdArabicLine, ForthArabicLine)
                        : string.Join("\n", FirstArabicLine, SecondArabicLine, ThirdArabicLine, ForthArabicLine, FifthArabicLine));

                    string EmailEnglishBody = (string.IsNullOrEmpty(FifthEnglishLine)
                        ? string.Join("\n", FirstEnglishLine, SecondEnglishLine, ThirdEnglishLine, ForthEnglishLine)
                        : string.Join("\n", FirstEnglishLine, SecondEnglishLine, ThirdEnglishLine, ForthEnglishLine, FifthEnglishLine));

                    string FullEmailBody = string.Join("\n", EmailArabicBody, EmailEnglishBody);

                    await _EmailSender.SendEmailAsync(Recipients, EmailSubject, FullEmailBody);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء الاجتماع بنجاح";

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
