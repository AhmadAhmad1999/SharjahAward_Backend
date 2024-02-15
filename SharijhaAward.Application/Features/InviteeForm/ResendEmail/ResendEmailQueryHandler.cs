﻿using AutoMapper;
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

namespace SharijhaAward.Application.Features.InviteeForm.ResendEmail
{
    internal class ResendEmailQueryHandler
        : IRequestHandler<ResendEmailQuery, Unit>
    {
        private readonly IAsyncRepository<PersonalInvitee> _PersonalInviteeRepository;
        private readonly IAsyncRepository<GroupInvitee> _GroupInviteeRepository;
        private IEmailSender _EmailSender;
        private IEmailCodesGenerator _QRCodeGenerator;
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public ResendEmailQueryHandler(
            IAsyncRepository<PersonalInvitee> personalInviteeRepository,
            IAsyncRepository<GroupInvitee> GroupInviteeRepository,
            IEmailSender EmailSender,
            IEmailCodesGenerator QRCodeGenerator,
            IAsyncRepository<Domain.Entities.EventModel.Event> EventRepository,
            IHttpContextAccessor HttpContextAccessor)
        {
            _PersonalInviteeRepository = personalInviteeRepository;
            _GroupInviteeRepository = GroupInviteeRepository;
            _EmailSender = EmailSender;
            _QRCodeGenerator = QRCodeGenerator;
            _EventRepository = EventRepository;
            _HttpContextAccessor = HttpContextAccessor;
        }

        public async Task<Unit> Handle(ResendEmailQuery Request, CancellationToken cancellationToken)
        {
            if (Request.Type.ToLower() == "Personal".ToLower())
            {
                PersonalInvitee PersonalInvitee = await _PersonalInviteeRepository.GetByIdAsync(Request.InviteeId);

                if (!string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() == "ar"
                    : false)
                {
                    // Generate QR Code..
                    Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(PersonalInvitee.EventId);
                    string EventName = EventEntity.ArabicName;
                    //string DataToSendIntoQR = $"{PersonalInvitee.Id}/Personal/{EventName}";
                    //string QRCodeImagePath = await _QRCodeGenerator.GenerateQRCode(DataToSendIntoQR, Request.ImagePath!);
                    //byte[] QRCodeBytes = File.ReadAllBytes(QRCodeImagePath);
                    //string QRbase64String = Convert.ToBase64String(QRCodeBytes);

                    // Generate BarCode..
                    string DataToSendIntoBarCode = $"{PersonalInvitee.UniqueIntegerId}";
                    string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.ImagePath!);

                    // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                    string HtmlBody = "wwwroot/QREmail_ar.html";

                    string HTMLContent = File.ReadAllText(HtmlBody);

                    CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                    bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                    //string DownloadQRImageAPI = isHttps
                    //    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadQRCode?QRCodeName={QRCodeImagePath.Split('/').LastOrDefault()}" +
                    //        $"&EventName={EventEntity.ArabicName}"
                    //    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadQRCode?QRCodeName={QRCodeImagePath.Split('/').LastOrDefault()}" +
                    //        $"&EventName={EventEntity.ArabicName}";

                    string DownloadBarCodeImageAPI = isHttps
                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}"
                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}";

                    DateTime GregorianDate = new DateTime(EventEntity.EventDate.Year, EventEntity.EventDate.Month,
                        EventEntity.EventDate.Day, EventEntity.EventDate.Hour, EventEntity.EventDate.Minute, EventEntity.EventDate.Second);

                    string ManipulatedBody = HTMLContent
                        .Replace("$NewInvitee.Name$", PersonalInvitee.Name, StringComparison.Ordinal) // Invited Name..
                        .Replace("$EventEntity.ArabicName$", EventEntity.ArabicName, StringComparison.Ordinal) // Event Name in Arabic..
                        .Replace("$EventEntity.ArabicLocation$", EventEntity.ArabicSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.DayOfWeek$", GregorianDate.ToString("dddd", ArabicCulture), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.Date$", GregorianDate.ToString("d/M/yyyy", ArabicCulture), StringComparison.Ordinal) // Event Date..
                        .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("HH:mm:ss", ArabicCulture), StringComparison.Ordinal) // Event Time..
                        //.Replace("[BASE64_ENCODED_IMAGE]", $"'data:image/png;base64,{QRbase64String}'") // Download QR Code Image..
                        //.Replace("$DownloadQRCodeAPI$", DownloadQRImageAPI); // Download QR Code Image API..
                        .Replace("$DownloadBarCodeAPI$", DownloadBarCodeImageAPI); // Download Bar Code Image API..

                    // Create An AlternateView to Specify The HTML Body And Embed The Image..
                    AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(ManipulatedBody, null, "text/html");

                    // Attach The Images As A Linked Resources..
                    //LinkedResource QRCodeImage = new LinkedResource(QRCodeImagePath) { ContentId = "QRCodeImage" }; // QR Code Image..
                    //AlternateView.LinkedResources.Add(QRCodeImage);

                    LinkedResource BarCodeImage = new LinkedResource(BarCodeImagePath) { ContentId = "BarCodeImage" }; // Bar Code Image..
                    AlternateView.LinkedResources.Add(BarCodeImage);

                    LinkedResource CaligraphyImage = new LinkedResource("wwwroot/assets/qr/caligraphy.png") { ContentId = "CaligraphyImage" }; // Caligraphy Image..
                    AlternateView.LinkedResources.Add(CaligraphyImage);

                    LinkedResource Email_HeaderImage = new LinkedResource("wwwroot/assets/qr/email_header.png") { ContentId = "Email_HeaderImage" }; // Email_Header Image..
                    AlternateView.LinkedResources.Add(Email_HeaderImage);

                    LinkedResource LogosImage = new LinkedResource("wwwroot/assets/qr/logos.png") { ContentId = "LogosImage" }; // Logos Image..
                    AlternateView.LinkedResources.Add(LogosImage);

                    EmailRequest EmailRequest = new EmailRequest()
                    {
                        ToEmail = PersonalInvitee.Email,
                        Subject = $"دعوة فردية لحضور {EventEntity.ArabicName}",
                        Body = ManipulatedBody,
                    };

                    await _EmailSender.SendEmail(EmailRequest, AlternateView);

                    return Unit.Value;
                }
                else
                {
                    // Generate QR Code..
                    Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(PersonalInvitee.EventId);
                    string EventName = EventEntity.EnglishName;
                    //string DataToSendIntoQR = $"{PersonalInvitee.Id}/Personal/{EventName}";
                    //string QRCodeImagePath = await _QRCodeGenerator.GenerateQRCode(DataToSendIntoQR, Request.ImagePath!);
                    //byte[] QRCodeBytes = File.ReadAllBytes(QRCodeImagePath);
                    //string QRbase64String = Convert.ToBase64String(QRCodeBytes);

                    // Generate BarCode..
                    string DataToSendIntoBarCode = $"{PersonalInvitee.UniqueIntegerId}";
                    string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.ImagePath!);

                    // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                    string HtmlBody = "wwwroot/QREmail_en.html";

                    string HTMLContent = File.ReadAllText(HtmlBody);

                    bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                    //string DownloadQRImageAPI = isHttps
                    //    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadQRCode?QRCodeName={QRCodeImagePath.Split('/').LastOrDefault()}" +
                    //        $"&EventName={EventEntity.ArabicName}"
                    //    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadQRCode?QRCodeName={QRCodeImagePath.Split('/').LastOrDefault()}" +
                    //        $"&EventName={EventEntity.ArabicName}";

                    string DownloadBarCodeImageAPI = isHttps
                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}"
                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}";

                    DateTime GregorianDate = new DateTime(EventEntity.EventDate.Year, EventEntity.EventDate.Month,
                        EventEntity.EventDate.Day, EventEntity.EventDate.Hour, EventEntity.EventDate.Minute, EventEntity.EventDate.Second);

                    string ManipulatedBody = HTMLContent
                        .Replace("$NewInvitee.Name$", PersonalInvitee.Name, StringComparison.Ordinal) // Invited Name..
                        .Replace("$EventEntity.EnglishName$", EventEntity.EnglishName, StringComparison.Ordinal) // Event Name in English..
                        .Replace("$EventEntity.EnglishLocation$", EventEntity.EnglishSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.DayOfWeek$", GregorianDate.DayOfWeek.ToString(), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.Date$", GregorianDate.ToString("d/M/yyyy"), StringComparison.Ordinal) // Event Date..
                        .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("HH:mm:ss"), StringComparison.Ordinal) // Event Time..
                        //.Replace("[BASE64_ENCODED_IMAGE]", $"'data:image/png;base64,{QRbase64String}'") // Download QR Code Image..
                        //.Replace("$DownloadQRCodeAPI$", DownloadQRImageAPI); // Download QR Code Image API..
                        .Replace("$DownloadBarCodeAPI$", DownloadBarCodeImageAPI); // Download Bar Code Image API..

                    // Create An AlternateView to Specify The HTML Body And Embed The Image..
                    AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(ManipulatedBody, null, "text/html");

                    // Attach The Images As A Linked Resources..
                    //LinkedResource QRCodeImage = new LinkedResource(QRCodeImagePath) { ContentId = "QRCodeImage" }; // QR Code Image..
                    //AlternateView.LinkedResources.Add(QRCodeImage);

                    LinkedResource BarCodeImage = new LinkedResource(BarCodeImagePath) { ContentId = "BarCodeImage" }; // Bar Code Image..
                    AlternateView.LinkedResources.Add(BarCodeImage);

                    LinkedResource CaligraphyImage = new LinkedResource("wwwroot/assets/qr/caligraphy.png") { ContentId = "CaligraphyImage" }; // Caligraphy Image..
                    AlternateView.LinkedResources.Add(CaligraphyImage);

                    LinkedResource Email_HeaderImage = new LinkedResource("wwwroot/assets/qr/email_header.png") { ContentId = "Email_HeaderImage" }; // Email_Header Image..
                    AlternateView.LinkedResources.Add(Email_HeaderImage);

                    LinkedResource LogosImage = new LinkedResource("wwwroot/assets/qr/logos.png") { ContentId = "LogosImage" }; // Logos Image..
                    AlternateView.LinkedResources.Add(LogosImage);

                    EmailRequest EmailRequest = new EmailRequest()
                    {
                        ToEmail = PersonalInvitee.Email,
                        Subject = $"Personal Invitation to attend {EventEntity.EnglishName}",
                        Body = ManipulatedBody,
                    };

                    await _EmailSender.SendEmail(EmailRequest, AlternateView);

                    return Unit.Value;
                }
            }
            else if (Request.Type.ToLower() == "Group".ToLower())
            {
                GroupInvitee GroupInvitee = await _GroupInviteeRepository.GetByIdAsync(Request.InviteeId);

                if (!string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() == "ar"
                    : false)
                {
                    // Generate QR Code..
                    Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(GroupInvitee.EventId);
                    string EventName = EventEntity.ArabicName;
                    //string DataToSendIntoQR = $"{GroupInvitee.Id}/Group/{EventName}";
                    //string QRCodeImagePath = await _QRCodeGenerator.GenerateQRCode(DataToSendIntoQR, Request.ImagePath!);
                    //byte[] QRCodeBytes = File.ReadAllBytes(QRCodeImagePath);
                    //string QRbase64String = Convert.ToBase64String(QRCodeBytes);

                    // Generate BarCode..
                    string DataToSendIntoBarCode = $"{GroupInvitee.UniqueIntegerId}";
                    string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.ImagePath!);

                    // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                    string HtmlBody = "wwwroot/QREmail_ar.html";

                    string HTMLContent = File.ReadAllText(HtmlBody);

                    CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                    bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                    //string DownloadQRImageAPI = isHttps
                    //    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadQRCode?QRCodeName={QRCodeImagePath.Split('/').LastOrDefault()}" +
                    //        $"&EventName={EventEntity.ArabicName}"
                    //    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadQRCode?QRCodeName={QRCodeImagePath.Split('/').LastOrDefault()}" +
                    //        $"&EventName={EventEntity.ArabicName}";

                    string DownloadBarCodeImageAPI = isHttps
                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}"
                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}";

                    string ManipulatedBody = HTMLContent
                        .Replace("$NewInvitee.Name$", GroupInvitee.Name, StringComparison.Ordinal) // Invited Name..
                        .Replace("$EventEntity.ArabicName$", EventEntity.ArabicName, StringComparison.Ordinal) // Event Name in Arabic..
                        .Replace("$EventEntity.ArabicLocation$", EventEntity.ArabicSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.DayOfWeek$", EventEntity.EventDate.ToString("dddd", ArabicCulture), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.Date$", EventEntity.EventDate.ToString("d/M/yyyy", ArabicCulture), StringComparison.Ordinal) // Event Date..
                        .Replace("$EventEntity.StartDate.TimeOfDay$", EventEntity.EventDate.ToString("HH:mm:ss", ArabicCulture), StringComparison.Ordinal) // Event Time..
                        //.Replace("[BASE64_ENCODED_IMAGE]", $"'data:image/png;base64,{QRbase64String}'") // Download QR Code Image..
                        //.Replace("$DownloadQRCodeAPI$", DownloadQRImageAPI); // Download QR Code Image API..
                        .Replace("$DownloadBarCodeAPI$", DownloadBarCodeImageAPI); // Download Bar Code Image API..

                    // Create An AlternateView to Specify The HTML Body And Embed The Image..
                    AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(ManipulatedBody, null, "text/html");

                    // Attach The Images As A Linked Resources..
                    //LinkedResource QRCodeImage = new LinkedResource(QRCodeImagePath) { ContentId = "QRCodeImage" }; // QR Code Image..
                    //AlternateView.LinkedResources.Add(QRCodeImage);

                    LinkedResource BarCodeImage = new LinkedResource(BarCodeImagePath) { ContentId = "BarCodeImage" }; // Bar Code Image..
                    AlternateView.LinkedResources.Add(BarCodeImage);

                    LinkedResource CaligraphyImage = new LinkedResource("wwwroot/assets/qr/caligraphy.png") { ContentId = "CaligraphyImage" }; // Caligraphy Image..
                    AlternateView.LinkedResources.Add(CaligraphyImage);

                    LinkedResource Email_HeaderImage = new LinkedResource("wwwroot/assets/qr/email_header.png") { ContentId = "Email_HeaderImage" }; // Email_Header Image..
                    AlternateView.LinkedResources.Add(Email_HeaderImage);

                    LinkedResource LogosImage = new LinkedResource("wwwroot/assets/qr/logos.png") { ContentId = "LogosImage" }; // Logos Image..
                    AlternateView.LinkedResources.Add(LogosImage);

                    EmailRequest EmailRequest = new EmailRequest()
                    {
                        ToEmail = GroupInvitee.Email,
                        Subject = $"دعوة جماعية لحضور {EventEntity.ArabicName}",
                        Body = ManipulatedBody,
                    };

                    await _EmailSender.SendEmail(EmailRequest, AlternateView);

                    return Unit.Value;
                }
                else
                {
                    // Generate QR Code..
                    Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(GroupInvitee.EventId);
                    string EventName = EventEntity.EnglishName;
                    //string DataToSendIntoQR = $"{GroupInvitee.Id}/Group/{EventName}";
                    //string QRCodeImagePath = await _QRCodeGenerator.GenerateQRCode(DataToSendIntoQR, Request.ImagePath!);
                    //byte[] QRCodeBytes = File.ReadAllBytes(QRCodeImagePath);
                    //string QRbase64String = Convert.ToBase64String(QRCodeBytes);

                    // Generate BarCode..
                    string DataToSendIntoBarCode = $"{GroupInvitee.UniqueIntegerId}";
                    string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.ImagePath!);

                    // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                    string HtmlBody = "wwwroot/QREmail_en.html";

                    string HTMLContent = File.ReadAllText(HtmlBody);

                    bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                    //string DownloadQRImageAPI = isHttps
                    //    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadQRCode?QRCodeName={QRCodeImagePath.Split('/').LastOrDefault()}" +
                    //        $"&EventName={EventEntity.ArabicName}"
                    //    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadQRCode?QRCodeName={QRCodeImagePath.Split('/').LastOrDefault()}" +
                    //        $"&EventName={EventEntity.ArabicName}";

                    string DownloadBarCodeImageAPI = isHttps
                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}"
                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadBarCode?BarCodeName={BarCodeImagePath.Split('\\').LastOrDefault()}";

                    DateTime GregorianDate = new DateTime(EventEntity.EventDate.Year, EventEntity.EventDate.Month,
                        EventEntity.EventDate.Day, EventEntity.EventDate.Hour, EventEntity.EventDate.Minute, EventEntity.EventDate.Second);

                    string ManipulatedBody = HTMLContent
                        .Replace("$NewInvitee.Name$", GroupInvitee.Name, StringComparison.Ordinal) // Invited Name..
                        .Replace("$EventEntity.EnglishName$", EventEntity.EnglishName, StringComparison.Ordinal) // Event Name in English..
                        .Replace("$EventEntity.EnglishLocation$", EventEntity.EnglishSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.DayOfWeek$", GregorianDate.DayOfWeek.ToString(), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.Date$", GregorianDate.ToString("d/M/yyyy"), StringComparison.Ordinal) // Event Date..
                        .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("HH:mm:ss"), StringComparison.Ordinal) // Event Time..
                        //.Replace("[BASE64_ENCODED_IMAGE]", $"'data:image/png;base64,{QRbase64String}'") // Download QR Code Image..
                        //.Replace("$DownloadQRCodeAPI$", DownloadQRImageAPI); // Download QR Code Image API..
                        .Replace("$DownloadBarCodeAPI$", DownloadBarCodeImageAPI); // Download Bar Code Image API..

                    // Create An AlternateView to Specify The HTML Body And Embed The Image..
                    AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(ManipulatedBody, null, "text/html");

                    // Attach The Images As A Linked Resources..
                    //LinkedResource QRCodeImage = new LinkedResource(QRCodeImagePath) { ContentId = "QRCodeImage" }; // QR Code Image..
                    //AlternateView.LinkedResources.Add(QRCodeImage);

                    LinkedResource BarCodeImage = new LinkedResource(BarCodeImagePath) { ContentId = "BarCodeImage" }; // Bar Code Image..
                    AlternateView.LinkedResources.Add(BarCodeImage);

                    LinkedResource CaligraphyImage = new LinkedResource("wwwroot/assets/qr/caligraphy.png") { ContentId = "CaligraphyImage" }; // Caligraphy Image..
                    AlternateView.LinkedResources.Add(CaligraphyImage);

                    LinkedResource Email_HeaderImage = new LinkedResource("wwwroot/assets/qr/email_header.png") { ContentId = "Email_HeaderImage" }; // Email_Header Image..
                    AlternateView.LinkedResources.Add(Email_HeaderImage);

                    LinkedResource LogosImage = new LinkedResource("wwwroot/assets/qr/logos.png") { ContentId = "LogosImage" }; // Logos Image..
                    AlternateView.LinkedResources.Add(LogosImage);

                    EmailRequest EmailRequest = new EmailRequest()
                    {
                        ToEmail = GroupInvitee.Email,
                        Subject = $"Group Invitation to attend {EventEntity.EnglishName}",
                        Body = ManipulatedBody,
                    };

                    await _EmailSender.SendEmail(EmailRequest, AlternateView);

                    return Unit.Value;
                }
            }

            return Unit.Value;
        }
    }
}
