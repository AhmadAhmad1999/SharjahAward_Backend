using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.NotificationModel;
using SharijhaAward.Domain.Entities.StaticNotificationModel;
using System.Globalization;
using System.Net.Http;
using System.Net.Mail;
using System.Transactions;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.SigningTheForm
{
    public class SigningTheFormQueryHandler
        : IRequestHandler<SigningTheFormQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IAsyncRepository<Notification> _NotificationRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IAsyncRepository<UserNotification> _UserNotificationRepository;
        private readonly IAsyncRepository<StaticNotification> _StaticNotificationRepository;
        private readonly IEmailSender _EmailSender;

        public SigningTheFormQueryHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository,
            IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository,
            IJwtProvider jwtProvider,
            IAsyncRepository<Notification> NotificationRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IAsyncRepository<UserNotification> UserNotificationRepository,
            IAsyncRepository<StaticNotification> _StaticNotificationRepository,
            IEmailSender EmailSender)
        {
            _formRepository = formRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _NotificationRepository = NotificationRepository;
            _UserTokenRepository = UserTokenRepository;
            _UserNotificationRepository = UserNotificationRepository;
            this._StaticNotificationRepository = _StaticNotificationRepository;
            _EmailSender = EmailSender;
        }

        public async Task<BaseResponse<object>> Handle(SigningTheFormQuery request, CancellationToken cancellationToken)
        {
            string msg;
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));
            if (User == null)
            {
                msg = request.lang == "en"
                    ? "You dont have permition"
                    : "لا تمتلك الصلاحية";

                return new BaseResponse<object>("", false, 401);
            }
            var form = await _formRepository
                .Where(f => f.userId == User.Id && f.Id == request.providedFormId)
                .Include(x => x.Category!.Parent!)
                .FirstOrDefaultAsync();

            if (form == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            else if (form.needSing == false)
            {
                msg = request.lang == "en"
                    ? "No need to send"
                    : "لا تحتاج للارسال";

                return new BaseResponse<object>(msg, false, 400);
            }

            byte[] salt = new byte[16] { 52, 123, 55, 148, 64, 30, 175, 37, 25, 240, 115, 57, 13, 255, 41, 74 };
            string CheckPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: request.password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            //var UserToken = _UserTokenRepository
            //    .Where(x => x.UserId == User.Id)
            //    .ToList();

            if (User.Password == CheckPassword)
            {

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
                        form.PercentCompletion = 100;
                        form.CurrentStep = form.TotalStep;
                        form.SubmitedAt = DateTime.Now;

                        await _formRepository.UpdateAsync(form);

                        string EmailSubject = $"Complete the steps to register for {form.Category.EnglishName} category" + " - " + $"تهانينا, لقد أتممت خطوات التسجيل في فئة {form.Category.ArabicName}";

                        CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                        DateTime DateTimeForNow = DateTime.UtcNow;

                        string FirstArabicLine = $"رقم الدورة: {form.CycleNumber}";
                        string SecondArabicLine = $"سنة الدورة: {form.CycleYear}";
                        string ThirdArabicLine = $"الفئة الرئيسية: {form.Category!.Parent!.ArabicName}";
                        string ForthArabicLine = $"الفئة الفرعية: {form.Category!.ArabicName}";
                        string FifthArabicLine = $"تاريخ التقديم: {DateTimeForNow.ToString("dddd", ArabicCulture)}" +
                            $"{DateTimeForNow.ToString("d/M/yyyy", ArabicCulture)}";
                        string SixthArabicLine = $"رقم الاستمارة: {form.Id}";

                        CultureInfo EnglishCulture = new CultureInfo("en-US");

                        string FirstEnglishLine = $"Cycle Number: {form.CycleNumber}";
                        string SecondEnglishLine = $"Cycle Year: {form.CycleYear}";
                        string ThirdEnglishLine = $"Main Category: {form.Category!.Parent!.EnglishName}";
                        string ForthEnglishLine = $"Sub Category: {form.Category!.EnglishName}";
                        string FifthEnglishLine = $"Date Of Submission: {DateTimeForNow.ToString("dddd", EnglishCulture)}" +
                            $"{DateTimeForNow.ToString("d/M/yyyy", EnglishCulture)}";
                        string SixthEnglisLine = $"Form Number: {form.Id}";

                        string HTMLContent = await File.ReadAllTextAsync(request.WWWRootFilePath + "/Send_Email_Template.html");

                        var Spliter = HTMLContent.Split("<!--MeetingLink-->");
                        HTMLContent = Spliter[0] + Spliter[2];

                        byte[] HeaderImageBytes = await File.ReadAllBytesAsync(request.WWWRootFilePath + "/assets/qr/header.png");
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

                        await _EmailSender.SendEmailAsync(new List<string>()
                        {
                            form.User!.Email
                        }, EmailSubject, FullEmailBody, AlternateView);

                        StaticNotification? StaticNotificationEntity = await _StaticNotificationRepository
                            .FirstOrDefaultAsync(x => x.StaticNotificationType == StaticNotificationTypes.AfterSigningTheForm &&
                                x.isActive);

                        if (StaticNotificationEntity is not null)
                        {
                            Notification NewNotificationEntity = new Notification()
                            {
                                ArabicTitle = StaticNotificationEntity!.ArabicTitle,
                                ArabicBody = StaticNotificationEntity!.ArabicBody,
                                EnglishTitle = StaticNotificationEntity!.EnglishTitle,
                                EnglishBody = StaticNotificationEntity!.EnglishBody
                            };

                            await _NotificationRepository.AddAsync(NewNotificationEntity);

                            List<FirebaseAdmin.Messaging.Message>? NotificationMessages = await _UserTokenRepository
                                .Where(x => User.Id == x.UserId && !string.IsNullOrEmpty(x.DeviceToken))
                                .Select(x => x.AppLanguage == "en"
                                    ? new FirebaseAdmin.Messaging.Message()
                                    {
                                        Notification = new FirebaseAdmin.Messaging.Notification
                                        {
                                            Title = NewNotificationEntity.EnglishTitle,
                                            Body = NewNotificationEntity.EnglishBody.Replace("$Email$", x.User!.Email)
                                        },
                                        Token = x.DeviceToken
                                    }
                                    : new FirebaseAdmin.Messaging.Message()
                                    {
                                        Notification = new FirebaseAdmin.Messaging.Notification
                                        {
                                            Title = NewNotificationEntity.ArabicTitle,
                                            Body = NewNotificationEntity.ArabicBody.Replace("$البريد الإلكتروني$", x.User!.Email)
                                        },
                                        Token = x.DeviceToken
                                    }).ToListAsync();

                            List<UserNotification> UserNotificationEntities = await _UserTokenRepository
                                .Where(x => User.Id == x.UserId)
                                .GroupBy(x => x.UserId)
                                .Select(x => new UserNotification()
                                {
                                    UserId = x.Key,
                                    NotificationId = NewNotificationEntity.Id,
                                    isReaded = false
                                }).ToListAsync();

                            if (UserNotificationEntities is not null)
                                await _UserNotificationRepository.AddRangeAsync(UserNotificationEntities!);

                            if (NotificationMessages is not null
                                ? NotificationMessages.Any()
                                : false)
                                await FirebaseAdmin.Messaging.FirebaseMessaging.DefaultInstance.SendEachAsync(NotificationMessages);
                        }

                        Transaction.Complete();
                    }
                    catch (Exception)
                    {
                        Transaction.Dispose();
                        throw;
                    }
                }

                msg = request.lang == "en"
                    ? "You Passed all Steps Succssfully"
                    : "تم التسجيل بنجاح";

                form.needSing = false;

                await _formRepository.UpdateAsync(form);

                return new BaseResponse<object>("", true, 200);
            }
            msg = request.lang == "en"
                ? "Password Is Not Correct"
                : "كلمة المرور غير صحيحة";
            return new BaseResponse<object>(msg, false, 400);
        }
    }
}
