using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.NotificationModel;
using SharijhaAward.Domain.Entities.StaticNotificationModel;
using System.Globalization;
using System.Net.Http;
using System.Net.Mail;
using System.Transactions;

namespace SharijhaAward.Application.Features.WinnersFeatures.Commands.ConfirmSelectedWinningForms
{
    public class ConfirmSelectedWinningFormsHandler : IRequestHandler<ConfirmSelectedWinningFormsCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IAsyncRepository<Notification> _NotificationRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IAsyncRepository<UserNotification> _UserNotificationRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<StaticNotification> _StaticNotificationRepository;
        private readonly IEmailSender _EmailSender;

        public ConfirmSelectedWinningFormsHandler(IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository,
            IAsyncRepository<Notification> _NotificationRepository,
            IAsyncRepository<UserToken> _UserTokenRepository,
            IAsyncRepository<UserNotification> _UserNotificationRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository,
            IAsyncRepository<StaticNotification> _StaticNotificationRepository,
            IEmailSender _EmailSender)
        {
            this._ArbitrationResultRepository = _ArbitrationResultRepository;
            this._NotificationRepository = _NotificationRepository;
            this._UserTokenRepository = _UserTokenRepository;
            this._UserNotificationRepository = _UserNotificationRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._StaticNotificationRepository = _StaticNotificationRepository;
            this._EmailSender = _EmailSender;
        }

        public async Task<BaseResponse<object>> Handle(ConfirmSelectedWinningFormsCommand Request, CancellationToken cancellationToken)
        {
            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            if (Request.EducationalClassId is null)
            {
                using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                    TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {
                        await _ArbitrationResultRepository
                            .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId && x.SelectedToWin &&
                                x.FinalArbitrationId != null)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.SelectedToWin, true)
                                .SetProperty(y => y.NotifiedAsWinner, true)
                                .SetProperty(y => y.WinningDate, DateTime.UtcNow)
                                .SetProperty(y => y.Winner, true));

                        List<IGrouping<float, ArbitrationResult>> ArbitrationResultEntities = _ArbitrationResultRepository
                            .Where(x => x.SelectedToWin &&
                                x.ProvidedForm!.categoryId == Request.CategoryId)
                            .Include(x => x.ProvidedForm!.Category!.Parent!)
                            .GroupBy(x => x.FinalArbitration!.FinalScore)
                            .AsEnumerable()
                            .OrderByDescending(x => x.Key)
                            .ToList();

                        int FirstWinningLevel = 1;

                        foreach (IGrouping<float, ArbitrationResult> ArbitrationResultEntity in ArbitrationResultEntities)
                        {
                            await _ArbitrationResultRepository
                                .Where(x => ArbitrationResultEntity.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId) &&
                                    x.FinalArbitrationId != null)
                                .ExecuteUpdateAsync(x => x.SetProperty(y => y.WinningLevel, FirstWinningLevel));

                            FirstWinningLevel++;
                        }

                        IEnumerable<int> UserIds = ArbitrationResultEntities
                            .SelectMany(x => x.ToList().Select(y => y.ProvidedForm!.userId));  

                        var ProvidedForms = ArbitrationResultEntities
                            .SelectMany(x => x.ToList().Select(y => y.ProvidedForm!));

                        foreach (var ProvidedForm in ProvidedForms)
                        {
                            string EmailSubject = "Winning the Sharjah Award for Educational Excellence and Distinction - الفوز بجائزة الشارقة للتميز والتفوق التربوي";

                            CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                            DateTime DateTimeForNow = DateTime.UtcNow;

                            string FirstArabicLine = $"رقم الدورة: {ProvidedForm.CycleNumber}";
                            string SecondArabicLine = $"سنة الدورة: {ProvidedForm.CycleYear}";
                            string ThirdArabicLine = $"الفئة الرئيسية: {ProvidedForm.Category!.Parent!.ArabicName}";
                            string ForthArabicLine = $"الفئة الفرعية: {ProvidedForm.Category!.ArabicName}";
                            string FifthArabicLine = $"تاريخ التقديم: {DateTimeForNow.ToString("dddd", ArabicCulture)}" +
                                $"{DateTimeForNow.ToString("d/M/yyyy", ArabicCulture)}";
                            string SixthArabicLine = $"رقم الاستمارة: {ProvidedForm.Id}";

                            CultureInfo EnglishCulture = new CultureInfo("en-US");

                            string FirstEnglishLine = $"Cycle Number: {ProvidedForm.CycleNumber}";
                            string SecondEnglishLine = $"Cycle Year: {ProvidedForm.CycleYear}";
                            string ThirdEnglishLine = $"Main Category: {ProvidedForm.Category!.Parent!.EnglishName}";
                            string ForthEnglishLine = $"Sub Category: {ProvidedForm.Category!.EnglishName}";
                            string FifthEnglishLine = $"Date Of Submission: {DateTimeForNow.ToString("dddd", EnglishCulture)}" +
                                $"{DateTimeForNow.ToString("d/M/yyyy", EnglishCulture)}";
                            string SixthEnglisLine = $"Form Number: {ProvidedForm.Id}";

                            string HTMLContent = await File.ReadAllTextAsync(Request.WWWRootFilePath + "/Send_Email_Template.html");

                            var Spliter = HTMLContent.Split("<!--MeetingLink-->");
                            HTMLContent = Spliter[0] + Spliter[2];

                            byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath + "/assets/qr/header.png");
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
                                ProvidedForm.User!.Email
                            }, EmailSubject, FullEmailBody, AlternateView);
                        }

                        StaticNotification? StaticNotificationEntity = await _StaticNotificationRepository
                            .FirstOrDefaultAsync(x => x.StaticNotificationType == StaticNotificationTypes.ConfirmSelectedWinningForms &&
                                x.isActive);

                        if (StaticNotificationEntity is not null)
                        {
                            Notification NewNotificationEntity = new Notification()
                            {
                                ArabicTitle = StaticNotificationEntity!.ArabicTitle,
                                ArabicBody = StaticNotificationEntity!.ArabicBody,
                                EnglishTitle = StaticNotificationEntity!.EnglishTitle,
                                EnglishBody = StaticNotificationEntity!.EnglishBody,
                                isStaticNotification = true
                            };

                            await _NotificationRepository.AddAsync(NewNotificationEntity);

                            List<FirebaseAdmin.Messaging.Message>? NotificationMessages = await _UserTokenRepository
                                .Where(x => UserIds.Contains(x.UserId) && !string.IsNullOrEmpty(x.DeviceToken))
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
                                .Where(x => UserIds.Contains(x.UserId))
                                .GroupBy(x => x.UserId)
                                .Select(x => new UserNotification()
                                {
                                    UserId = x.Key,
                                    NotificationId = NewNotificationEntity.Id,
                                    isReaded = false,
                                    Action = "winners"
                                }).ToListAsync();

                            if (UserNotificationEntities is not null)
                                await _UserNotificationRepository.AddRangeAsync(UserNotificationEntities!);

                            if (NotificationMessages is not null
                                ? NotificationMessages.Any()
                                : false)
                                await FirebaseAdmin.Messaging.FirebaseMessaging.DefaultInstance.SendEachAsync(NotificationMessages);
                        }

                        Transaction.Complete();

                        string ResponseMessage = Request.lang == "en"
                            ? "Winners in this category were successfully selected"
                            : "تم اختيار الفائزين في هذه الفئة بنجاح";

                        return new BaseResponse<object>(ResponseMessage, true, 200);
                    }
                    catch (Exception)
                    {
                        Transaction.Dispose();
                        throw;
                    }
                }
            }
            else
            {
                using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                    TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {
                        await _ArbitrationResultRepository
                            .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId && x.SelectedToWin &&
                                x.ProvidedForm!.CategoryEducationalClass!.EducationalClassId == Request.EducationalClassId &&
                                x.FinalArbitrationId != null)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.SelectedToWin, true)
                                .SetProperty(y => y.NotifiedAsWinner, true)
                                .SetProperty(y => y.WinningDate, DateTime.UtcNow)
                                .SetProperty(y => y.Winner, true));

                        List<IGrouping<float, ArbitrationResult>> ArbitrationResultEntities = _ArbitrationResultRepository
                            .Where(x => x.SelectedToWin &&
                                x.ProvidedForm!.categoryId == Request.CategoryId &&
                                x.ProvidedForm!.CategoryEducationalClass!.EducationalClassId == Request.EducationalClassId)
                            .GroupBy(x => x.FinalArbitration!.FinalScore)
                            .AsEnumerable()
                            .OrderByDescending(x => x.Key)
                            .ToList();

                        int FirstWinningLevel = 1;

                        foreach (IGrouping<float, ArbitrationResult> ArbitrationResultEntity in ArbitrationResultEntities)
                        {
                            await _ArbitrationResultRepository
                                .Where(x => ArbitrationResultEntity.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId) &&
                                    x.FinalArbitrationId != null)
                                .ExecuteUpdateAsync(x => x.SetProperty(y => y.WinningLevel, FirstWinningLevel));

                            FirstWinningLevel++;
                        }

                        IEnumerable<int> UserIds = ArbitrationResultEntities
                            .SelectMany(x => x.ToList().Select(y => y.ProvidedForm!.userId));

                        var ProvidedForms = ArbitrationResultEntities
                            .SelectMany(x => x.ToList().Select(y => y.ProvidedForm!));

                        foreach (var ProvidedForm in ProvidedForms)
                        {
                            string EmailSubject = "Winning the Sharjah Award for Educational Excellence and Distinction - الفوز بجائزة الشارقة للتميز والتفوق التربوي";

                            CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                            DateTime DateTimeForNow = DateTime.UtcNow;

                            string FirstArabicLine = $"رقم الدورة: {ProvidedForm.CycleNumber}";
                            string SecondArabicLine = $"سنة الدورة: {ProvidedForm.CycleYear}";
                            string ThirdArabicLine = $"الفئة الرئيسية: {ProvidedForm.Category!.Parent!.ArabicName}";
                            string ForthArabicLine = $"الفئة الفرعية: {ProvidedForm.Category!.ArabicName}";
                            string FifthArabicLine = $"تاريخ التقديم: {DateTimeForNow.ToString("dddd", ArabicCulture)}" +
                                $"{DateTimeForNow.ToString("d/M/yyyy", ArabicCulture)}";
                            string SixthArabicLine = $"رقم الاستمارة: {ProvidedForm.Id}";

                            CultureInfo EnglishCulture = new CultureInfo("en-US");

                            string FirstEnglishLine = $"Cycle Number: {ProvidedForm.CycleNumber}";
                            string SecondEnglishLine = $"Cycle Year: {ProvidedForm.CycleYear}";
                            string ThirdEnglishLine = $"Main Category: {ProvidedForm.Category!.Parent!.EnglishName}";
                            string ForthEnglishLine = $"Sub Category: {ProvidedForm.Category!.EnglishName}";
                            string FifthEnglishLine = $"Date Of Submission: {DateTimeForNow.ToString("dddd", EnglishCulture)}" +
                                $"{DateTimeForNow.ToString("d/M/yyyy", EnglishCulture)}";
                            string SixthEnglisLine = $"Form Number: {ProvidedForm.Id}";

                            string HTMLContent = await File.ReadAllTextAsync(Request.WWWRootFilePath + "/Send_Email_Template.html");

                            var Spliter = HTMLContent.Split("<!--MeetingLink-->");
                            HTMLContent = Spliter[0] + Spliter[2];

                            byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath + "/assets/qr/header.png");
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
                                ProvidedForm.User!.Email
                            }, EmailSubject, FullEmailBody, AlternateView);
                        }

                        StaticNotification? StaticNotificationEntity = await _StaticNotificationRepository
                            .FirstOrDefaultAsync(x => x.StaticNotificationType == StaticNotificationTypes.ConfirmSelectedWinningForms &&
                                x.isActive);

                        if (StaticNotificationEntity is not null)
                        {
                            Notification NewNotificationEntity = new Notification()
                            {
                                ArabicTitle = StaticNotificationEntity!.ArabicTitle,
                                ArabicBody = StaticNotificationEntity!.ArabicBody,
                                EnglishTitle = StaticNotificationEntity!.EnglishTitle,
                                EnglishBody = StaticNotificationEntity!.EnglishBody,
                                isStaticNotification = true
                            };

                            await _NotificationRepository.AddAsync(NewNotificationEntity);

                            List<FirebaseAdmin.Messaging.Message>? NotificationMessages = await _UserTokenRepository
                                .Where(x => UserIds.Contains(x.UserId) && !string.IsNullOrEmpty(x.DeviceToken))
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
                                .Where(x => UserIds.Contains(x.UserId))
                                .GroupBy(x => x.UserId)
                                .Select(x => new UserNotification()
                                {
                                    UserId = x.Key,
                                    NotificationId = NewNotificationEntity.Id,
                                    isReaded = false,
                                    Action = "winners"
                                }).ToListAsync();

                            if (UserNotificationEntities is not null)
                                await _UserNotificationRepository.AddRangeAsync(UserNotificationEntities!);

                            if (NotificationMessages is not null
                                ? NotificationMessages.Any()
                                : false)
                                await FirebaseAdmin.Messaging.FirebaseMessaging.DefaultInstance.SendEachAsync(NotificationMessages);
                        }

                        Transaction.Complete();

                        string ResponseMessage = Request.lang == "en"
                            ? "Winners in this category's class were successfully selected"
                            : "تم اختيار الفائزين في صف هذه الفئة بنجاح";

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
}
