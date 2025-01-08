using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalInviteeById;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharijhaAward.Application.Models;
using System.Net.Mail;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Microsoft.AspNetCore.Html;
using SharijhaAward.Domain.Entities.EventModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InviteeForm.ResendEmail
{
    internal class ResendEmailQueryHandler
        : IRequestHandler<ResendEmailQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<PersonalInviteeVirtualTable> _PersonalInviteeVirtualTableRepository;
        private readonly IAsyncRepository<GroupInviteeVirtualTable> _GroupInviteeVirtualTableRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        private IEmailSender _EmailSender;
        private IEmailCodesGenerator _QRCodeGenerator;
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public ResendEmailQueryHandler(IAsyncRepository<PersonalInviteeVirtualTable> _PersonalInviteeVirtualTableRepository,
            IAsyncRepository<GroupInviteeVirtualTable> _GroupInviteeVirtualTableRepository,
            IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository,
            IEmailSender EmailSender,
            IEmailCodesGenerator QRCodeGenerator,
            IAsyncRepository<Domain.Entities.EventModel.Event> EventRepository,
            IHttpContextAccessor HttpContextAccessor)
        {
            this._PersonalInviteeVirtualTableRepository = _PersonalInviteeVirtualTableRepository;
            this._GroupInviteeVirtualTableRepository = _GroupInviteeVirtualTableRepository;
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._DynamicAttributeTableValueRepository = _DynamicAttributeTableValueRepository;
            _EmailSender = EmailSender;
            _QRCodeGenerator = QRCodeGenerator;
            _EventRepository = EventRepository;
            _HttpContextAccessor = HttpContextAccessor;
        }

        public async Task<BaseResponse<object>> Handle(ResendEmailQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;
            if (Request.Type.ToLower() == "Personal".ToLower())
            {
                PersonalInviteeVirtualTable? PersonalInvitee = await _PersonalInviteeVirtualTableRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.InviteeId);

                if (PersonalInvitee is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Personal invitee is not found"
                        : "الدعوة الفردية غير موجودة";

                    return new BaseResponse<object>(ResponseMessage, false, 404);
                }

                if (!string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() == "ar"
                    : false)
                {
                    DynamicAttributeValue? DynamicAttributeValueEntity = await _DynamicAttributeValueRepository
                        .FirstOrDefaultAsync(x => x.RecordId == Request.InviteeId &&
                            x.DynamicAttribute!.DynamicAttributeSection!.InviteeType == Domain.Constants.InviteeTypes.Personal &&
                            x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                            x.DynamicAttribute!.EnglishLabel == "Email");

                    int? EventId = 0;

                    if (DynamicAttributeValueEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Email is not found"
                            : "الايميل غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    if (DynamicAttributeValueEntity is not null)
                        EventId = DynamicAttributeValueEntity.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation;

                    Domain.Entities.EventModel.Event? EventEntity = await _EventRepository
                        .FirstOrDefaultAsync(x => x.Id == EventId);

                    if (EventEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Event is not found"
                            : "الفعالية غير موجودة";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    // Generate BarCode..
                    string DataToSendIntoBarCode = $"{PersonalInvitee.UniqueIntegerId}";
                    string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.ImagePath!);

                    // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                    string HTMLContent = await File.ReadAllTextAsync(Request.ImagePath + "/QREmail_ar.html");

                    CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                    bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                    string DownloadedHTMLFileName = Guid.NewGuid().ToString() + ".html";
                    string DownloadedHTMLFilePath = Request.ImagePath + "/HTMLCodes/" + DownloadedHTMLFileName;

                    string DownloadBarCodeImageAPI = isHttps
                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}"
                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}";

                    DateTime GregorianDate = new DateTime(EventEntity.EventDate.Year, EventEntity.EventDate.Month,
                        EventEntity.EventDate.Day, EventEntity.EventDate.Hour, EventEntity.EventDate.Minute, EventEntity.EventDate.Second);

                    string ManipulatedBody = HTMLContent
                        .Replace("$NewInvitee.Name$", "") // Invited Name..
                        .Replace("$EventEntity.ArabicName$", EventEntity.ArabicName, StringComparison.Ordinal) // Event Name in Arabic..
                        .Replace("$EventEntity.ArabicLocation$", EventEntity.ArabicSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.DayOfWeek$", GregorianDate.ToString("dddd", ArabicCulture), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.Date$", GregorianDate.ToString("d/M/yyyy", ArabicCulture), StringComparison.Ordinal) // Event Date..
                        .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("hh:mm tt", ArabicCulture), StringComparison.Ordinal) // Event Time..
                        .Replace("$DownloadBarCodeAPI$", DownloadBarCodeImageAPI); // Download Bar Code Image API..

                    // Create An AlternateView to Specify The HTML Body And Embed The Image..
                    AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(ManipulatedBody, null, "text/html");

                    // Attach The Images As A Linked Resources..
                    
                    LinkedResource BarCodeImage = new LinkedResource(BarCodeImagePath) { ContentId = "BarCodeImage" }; // Bar Code Image..
                    AlternateView.LinkedResources.Add(BarCodeImage);

                    LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                    AlternateView.LinkedResources.Add(HeaderImage);

                    EmailRequest EmailRequest = new EmailRequest()
                    {
                        ToEmail = DynamicAttributeValueEntity!.Value,
                        Subject = $"دعوة فردية لحضور {EventEntity.ArabicName}",
                        Body = ManipulatedBody,
                    };

                    byte[] BarCodeImageImageBytes = await File.ReadAllBytesAsync(BarCodeImagePath);
                    string BarCodeImagebase64String = Convert.ToBase64String(BarCodeImageImageBytes);

                    byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.ImagePath + "/assets/qr/header.png");
                    string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                    string ManipulatedBodyForPdf = ManipulatedBody
                        .Replace("\"cid:BarCodeImage\"", $"'data:image/png;base64,{BarCodeImagebase64String}'")
                        .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                    List<string>? ManipulatedBodyForPdfSpliter = ManipulatedBodyForPdf.Split("<!--here-->").ToList();
                    ManipulatedBodyForPdf = ManipulatedBodyForPdfSpliter[0] + ManipulatedBodyForPdfSpliter[2];

                    try
                    {
                        await _EmailSender.SendEmail(EmailRequest, AlternateView);

                        await File.WriteAllTextAsync(DownloadedHTMLFilePath, ManipulatedBodyForPdf, Encoding.UTF8);
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    ResponseMessage = Request.lang == "en"
                        ? "The email is resended successfully"
                        : "تمت إعادة إرسال الإيميل بنجاح";

                    return new BaseResponse<object>(ResponseMessage, false, 200);
                }
                else
                {
                    DynamicAttributeValue? DynamicAttributeValueEntity = await _DynamicAttributeValueRepository
                        .FirstOrDefaultAsync(x => x.RecordId == Request.InviteeId &&
                            x.DynamicAttribute!.DynamicAttributeSection!.InviteeType == Domain.Constants.InviteeTypes.Personal &&
                            x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                            x.DynamicAttribute!.EnglishLabel == "Email");

                    int? EventId = 0;

                    if (DynamicAttributeValueEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Email is not found"
                            : "الإيميل غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    if (DynamicAttributeValueEntity is not null)
                        EventId = DynamicAttributeValueEntity.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation;

                    Domain.Entities.EventModel.Event? EventEntity = await _EventRepository
                        .FirstOrDefaultAsync(x => x.Id == EventId);

                    if (EventEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Event is not found"
                            : "الفعالية غير موجودة";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    CultureInfo EnglishCulture = new CultureInfo("en-US");

                    // Generate BarCode..
                    string DataToSendIntoBarCode = $"{PersonalInvitee.UniqueIntegerId}";
                    string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.ImagePath!);

                    // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                    string HTMLContent = await File.ReadAllTextAsync(Request.ImagePath + "/QREmail_en.html");

                    bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                    string DownloadedHTMLFileName = Guid.NewGuid().ToString() + ".html";
                    string DownloadedHTMLFilePath = Request.ImagePath + "/HTMLCodes/" + DownloadedHTMLFileName;

                    string DownloadBarCodeImageAPI = isHttps
                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}"
                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}";

                    DateTime GregorianDate = new DateTime(EventEntity.EventDate.Year, EventEntity.EventDate.Month,
                        EventEntity.EventDate.Day, EventEntity.EventDate.Hour, EventEntity.EventDate.Minute, EventEntity.EventDate.Second);

                    string ManipulatedBody = HTMLContent
                        .Replace("$NewInvitee.Name$", "") // Invited Name..
                        .Replace("$EventEntity.EnglishName$", EventEntity.EnglishName, StringComparison.Ordinal) // Event Name in English..
                        .Replace("$EventEntity.EnglishLocation$", EventEntity.EnglishSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.DayOfWeek$", GregorianDate.DayOfWeek.ToString(), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.Date$", GregorianDate.ToString("d/M/yyyy", EnglishCulture), StringComparison.Ordinal) // Event Date..
                        .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("hh:mm tt", EnglishCulture), StringComparison.Ordinal) // Event Time..
                        .Replace("$DownloadBarCodeAPI$", DownloadBarCodeImageAPI); // Download Bar Code Image API..

                    // Create An AlternateView to Specify The HTML Body And Embed The Image..
                    AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(ManipulatedBody, null, "text/html");

                    // Attach The Images As A Linked Resources..
                    LinkedResource BarCodeImage = new LinkedResource(BarCodeImagePath) { ContentId = "BarCodeImage" }; // Bar Code Image..
                    AlternateView.LinkedResources.Add(BarCodeImage);

                    LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                    AlternateView.LinkedResources.Add(HeaderImage);

                    EmailRequest EmailRequest = new EmailRequest()
                    {
                        ToEmail = DynamicAttributeValueEntity!.Value,
                        Subject = $"Personal Invitation to attend {EventEntity.EnglishName}",
                        Body = ManipulatedBody,
                    };

                    byte[] BarCodeImageImageBytes = await File.ReadAllBytesAsync(BarCodeImagePath);
                    string BarCodeImagebase64String = Convert.ToBase64String(BarCodeImageImageBytes);

                    byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.ImagePath + "/assets/qr/header.png");
                    string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                    string ManipulatedBodyForPdf = ManipulatedBody
                        .Replace("\"cid:BarCodeImage\"", $"'data:image/png;base64,{BarCodeImagebase64String}'")
                        .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                    List<string>? ManipulatedBodyForPdfSpliter = ManipulatedBodyForPdf.Split("<!--here-->").ToList();
                    ManipulatedBodyForPdf = ManipulatedBodyForPdfSpliter[0] + ManipulatedBodyForPdfSpliter[2];

                    try
                    {
                        await _EmailSender.SendEmail(EmailRequest, AlternateView);

                        await File.WriteAllTextAsync(DownloadedHTMLFilePath, ManipulatedBodyForPdf, Encoding.UTF8);
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    ResponseMessage = Request.lang == "en"
                        ? "The email is resended successfully"
                        : "تمت إعادة إرسال الإيميل بنجاح";

                    return new BaseResponse<object>(ResponseMessage, false, 200);
                }
            }
            else if (Request.Type.ToLower() == "Group".ToLower())
            {
                GroupInviteeVirtualTable? GroupInvitee = await _GroupInviteeVirtualTableRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.InviteeId);

                if (GroupInvitee is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Group invitee is not found"
                        : "الدعوة الجماعية غير موجودة";

                    return new BaseResponse<object>(ResponseMessage, false, 404);
                }

                if (!string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() == "ar"
                    : false)
                {
                    DynamicAttributeValue? DynamicAttributeValueEntity = await _DynamicAttributeValueRepository
                        .FirstOrDefaultAsync(x => x.RecordId == Request.InviteeId &&
                            x.DynamicAttribute!.DynamicAttributeSection!.InviteeType == Domain.Constants.InviteeTypes.Group &&
                            x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                            x.DynamicAttribute!.EnglishLabel == "Email (Student Supervisor)");

                    int? EventId = 0;

                    if (DynamicAttributeValueEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Email is not found"
                            : "الإيميل غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    if (DynamicAttributeValueEntity is not null)
                        EventId = DynamicAttributeValueEntity.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation;

                    Domain.Entities.EventModel.Event? EventEntity = await _EventRepository
                        .FirstOrDefaultAsync(x => x.Id == EventId);

                    if (EventEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Event is not found"
                            : "الفعالية غير موجودة";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    // Generate BarCode..
                    string DataToSendIntoBarCode = $"{GroupInvitee.UniqueIntegerId}";
                    string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.ImagePath!);

                    // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                    string HTMLContent = await File.ReadAllTextAsync(Request.ImagePath + "/QREmail_ar.html");

                    CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                    bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                    string DownloadedHTMLFileName = Guid.NewGuid().ToString() + ".html";
                    string DownloadedHTMLFilePath = Request.ImagePath + "/HTMLCodes/" + DownloadedHTMLFileName;

                    string DownloadBarCodeImageAPI = isHttps
                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}"
                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}";

                    string ManipulatedBody = HTMLContent
                        .Replace("$NewInvitee.Name$", "") // Invited Name..
                        .Replace("$EventEntity.ArabicName$", EventEntity.ArabicName, StringComparison.Ordinal) // Event Name in Arabic..
                        .Replace("$EventEntity.ArabicLocation$", EventEntity.ArabicSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.DayOfWeek$", EventEntity.EventDate.ToString("dddd", ArabicCulture), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.Date$", EventEntity.EventDate.ToString("d/M/yyyy", ArabicCulture), StringComparison.Ordinal) // Event Date..
                        .Replace("$EventEntity.StartDate.TimeOfDay$", EventEntity.EventDate.ToString("hh:mm tt", ArabicCulture), StringComparison.Ordinal) // Event Time..
                        .Replace("$DownloadBarCodeAPI$", DownloadBarCodeImageAPI); // Download Bar Code Image API..

                    // Create An AlternateView to Specify The HTML Body And Embed The Image..
                    AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(ManipulatedBody, null, "text/html");

                    // Attach The Images As A Linked Resources..
                    LinkedResource BarCodeImage = new LinkedResource(BarCodeImagePath) { ContentId = "BarCodeImage" }; // Bar Code Image..
                    AlternateView.LinkedResources.Add(BarCodeImage);

                    LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                    AlternateView.LinkedResources.Add(HeaderImage);

                    EmailRequest EmailRequest = new EmailRequest()
                    {
                        ToEmail = DynamicAttributeValueEntity.Value,
                        Subject = $"دعوة جماعية لحضور {EventEntity.ArabicName}",
                        Body = ManipulatedBody,
                    };

                    byte[] BarCodeImageImageBytes = await File.ReadAllBytesAsync(BarCodeImagePath);
                    string BarCodeImagebase64String = Convert.ToBase64String(BarCodeImageImageBytes);

                    byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.ImagePath + "/assets/qr/header.png");
                    string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                    string ManipulatedBodyForPdf = ManipulatedBody
                        .Replace("\"cid:BarCodeImage\"", $"'data:image/png;base64,{BarCodeImagebase64String}'")
                        .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                    List<string>? ManipulatedBodyForPdfSpliter = ManipulatedBodyForPdf.Split("<!--here-->").ToList();
                    ManipulatedBodyForPdf = ManipulatedBodyForPdfSpliter[0] + ManipulatedBodyForPdfSpliter[2];

                    try
                    {
                        await _EmailSender.SendEmail(EmailRequest, AlternateView);

                        await File.WriteAllTextAsync(DownloadedHTMLFilePath, ManipulatedBodyForPdf, Encoding.UTF8);
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    ResponseMessage = Request.lang == "en"
                        ? "The email is resended successfully"
                        : "تمت إعادة إرسال الإيميل بنجاح";

                    return new BaseResponse<object>(ResponseMessage, false, 200);
                }
                else
                {
                    DynamicAttributeValue? DynamicAttributeValueEntity = await _DynamicAttributeValueRepository
                        .FirstOrDefaultAsync(x => x.RecordId == Request.InviteeId &&
                            x.DynamicAttribute!.DynamicAttributeSection!.InviteeType == Domain.Constants.InviteeTypes.Group &&
                            x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                            x.DynamicAttribute!.EnglishLabel == "Email (Student Supervisor)");

                    int? EventId = 0;

                    if (DynamicAttributeValueEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Email is not found"
                            : "الإيميل غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    if (DynamicAttributeValueEntity is not null)
                        EventId = DynamicAttributeValueEntity.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation;

                    Domain.Entities.EventModel.Event? EventEntity = await _EventRepository
                        .FirstOrDefaultAsync(x => x.Id == EventId);

                    if (EventEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Event is not found"
                            : "الفعالية غير موجودة";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    CultureInfo EnglishCulture = new CultureInfo("en-US");

                    // Generate BarCode..
                    string DataToSendIntoBarCode = $"{GroupInvitee.UniqueIntegerId}";
                    string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.ImagePath!);

                    // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                    string HTMLContent = await File.ReadAllTextAsync(Request.ImagePath + "/QREmail_en.html");

                    bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                    string DownloadedHTMLFileName = Guid.NewGuid().ToString() + ".html";
                    string DownloadedHTMLFilePath = Request.ImagePath + "/HTMLCodes/" + DownloadedHTMLFileName;

                    string DownloadBarCodeImageAPI = isHttps
                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}"
                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}";

                    DateTime GregorianDate = new DateTime(EventEntity.EventDate.Year, EventEntity.EventDate.Month,
                        EventEntity.EventDate.Day, EventEntity.EventDate.Hour, EventEntity.EventDate.Minute, EventEntity.EventDate.Second);

                    string ManipulatedBody = HTMLContent
                        .Replace("$NewInvitee.Name$", "") // Invited Name..
                        .Replace("$EventEntity.EnglishName$", EventEntity.EnglishName, StringComparison.Ordinal) // Event Name in English..
                        .Replace("$EventEntity.EnglishLocation$", EventEntity.EnglishSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.DayOfWeek$", GregorianDate.DayOfWeek.ToString(), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.Date$", GregorianDate.ToString("d/M/yyyy", EnglishCulture), StringComparison.Ordinal) // Event Date..
                        .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("hh:mm tt", EnglishCulture), StringComparison.Ordinal) // Event Time..
                        .Replace("$DownloadBarCodeAPI$", DownloadBarCodeImageAPI); // Download Bar Code Image API..

                    // Create An AlternateView to Specify The HTML Body And Embed The Image..
                    AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(ManipulatedBody, null, "text/html");

                    // Attach The Images As A Linked Resources..
                    LinkedResource BarCodeImage = new LinkedResource(BarCodeImagePath) { ContentId = "BarCodeImage" }; // Bar Code Image..
                    AlternateView.LinkedResources.Add(BarCodeImage);

                    LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                    AlternateView.LinkedResources.Add(HeaderImage);

                    EmailRequest EmailRequest = new EmailRequest()
                    {
                        ToEmail = DynamicAttributeValueEntity.Value,
                        Subject = $"Group Invitation to attend {EventEntity.EnglishName}",
                        Body = ManipulatedBody,
                    };

                    byte[] BarCodeImageImageBytes = await File.ReadAllBytesAsync(BarCodeImagePath);
                    string BarCodeImagebase64String = Convert.ToBase64String(BarCodeImageImageBytes);

                    byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.ImagePath + "/assets/qr/header.png");
                    string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                    string ManipulatedBodyForPdf = ManipulatedBody
                        .Replace("\"cid:BarCodeImage\"", $"'data:image/png;base64,{BarCodeImagebase64String}'")
                        .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                    List<string>? ManipulatedBodyForPdfSpliter = ManipulatedBodyForPdf.Split("<!--here-->").ToList();
                    ManipulatedBodyForPdf = ManipulatedBodyForPdfSpliter[0] + ManipulatedBodyForPdfSpliter[2];

                    try
                    {
                        await _EmailSender.SendEmail(EmailRequest, AlternateView);

                        await File.WriteAllTextAsync(DownloadedHTMLFilePath, ManipulatedBodyForPdf, Encoding.UTF8);
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    ResponseMessage = Request.lang == "en"
                        ? "The email is resended successfully"
                        : "تمت إعادة إرسال الإيميل بنجاح";

                    return new BaseResponse<object>(ResponseMessage, false, 200);
                }
            }

            return new BaseResponse<object>(ResponseMessage, false, 500);
        }
    }
}
