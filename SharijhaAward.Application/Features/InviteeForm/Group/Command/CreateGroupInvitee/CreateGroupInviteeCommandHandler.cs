using AutoMapper;
using FluentValidation;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
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
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee
{
    public class CreateGroupInviteeCommandHandler
        : IRequestHandler<CreateGroupInviteeCommand, Unit>
    {
        private readonly IAsyncRepository<GroupInvitee> _groupInviteeRepository;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository;
        private IEmailSender _EmailSender;
        private IEmailCodesGenerator _QRCodeGenerator;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public CreateGroupInviteeCommandHandler(IAsyncRepository<GroupInvitee> groupInviteeRepository, IMapper mapper,
            IEmailCodesGenerator QRCodeGenerator,
            IAsyncRepository<Domain.Entities.EventModel.Event> EventRepository,
            IEmailSender EmailSender,
            IHttpContextAccessor HttpContextAccessor)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _mapper = mapper;
            _QRCodeGenerator = QRCodeGenerator;
            _EventRepository = EventRepository;
            _EmailSender = EmailSender;
            _HttpContextAccessor = HttpContextAccessor;
        }

        public async Task<Unit> Handle(CreateGroupInviteeCommand Request, CancellationToken cancellationToken)
        {
            CreateGroupInviteeCommandValidator Validator = new CreateGroupInviteeCommandValidator();
            ValidationResult? ValidationResult = await Validator.ValidateAsync(Request);

            if (ValidationResult.Errors.Count > 0)
                throw new ValidationException(ValidationResult.Errors);

            GroupInvitee? NewGroupInvitee = _mapper.Map<GroupInvitee>(Request);
            IEnumerable<int> ListOfUniqueIntegerId = _groupInviteeRepository.ListAllAsync()
                .Result.Select(x => x.UniqueIntegerId);
            
            Random Random = new Random();
            int UniqueIntegerId;
            do
            {
                UniqueIntegerId = Random.Next();
            } while (ListOfUniqueIntegerId.Contains(UniqueIntegerId));

            NewGroupInvitee.UniqueIntegerId = UniqueIntegerId;
            //try
            //{
            //    NewGroupInvitee = await _groupInviteeRepository.AddAsync(NewGroupInvitee);
            //}
            //catch (DbUpdateException)
            //{
            //    throw;
            //}

            if (!string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() == "ar"
                : false)
            {
                // Generate QR Code..
                Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(NewGroupInvitee.EventId);
                string EventName = EventEntity.ArabicName;
                //string DataToSendIntoQR = $"{NewGroupInvitee.Id}/Group/{EventName}";
                //string QRCodeImagePath = await _QRCodeGenerator.GenerateQRCode(DataToSendIntoQR, Request.ImagePath!);
                //byte[] QRCodeBytes = File.ReadAllBytes(QRCodeImagePath);
                //string QRbase64String = Convert.ToBase64String(QRCodeBytes);

                // Generate BarCode..
                string DataToSendIntoBarCode = $"{NewGroupInvitee.UniqueIntegerId}";
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
                    .Replace("$NewInvitee.Name$", NewGroupInvitee.Name, StringComparison.Ordinal) // Invited Name..
                    .Replace("$EventEntity.ArabicName$", EventEntity.ArabicName, StringComparison.Ordinal) // Event Name in Arabic..
                    .Replace("$EventEntity.ArabicLocation$", EventEntity.ArabicSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                    .Replace("$EventEntity.StartDate.DayOfWeek$", EventEntity.StartDate.ToString("dddd", ArabicCulture), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                    .Replace("$EventEntity.StartDate.Date$", EventEntity.StartDate.ToString("M/d/yyyy", ArabicCulture), StringComparison.Ordinal) // Event Date..
                    .Replace("$EventEntity.StartDate.TimeOfDay$", EventEntity.StartDate.ToString("HH:mm:ss", ArabicCulture), StringComparison.Ordinal) // Event Time..
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
                    ToEmail = NewGroupInvitee.Email,
                    Subject = $"دعوة جماعية لحضور {EventEntity.ArabicName}",
                    Body = ManipulatedBody,
                };

                await _EmailSender.SendEmail(EmailRequest, AlternateView);

                try
                {
                    NewGroupInvitee = await _groupInviteeRepository.AddAsync(NewGroupInvitee);
                }
                catch (DbUpdateException)
                {
                    throw;
                }
            }
            else
            {
                // Generate QR Code..
                Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(NewGroupInvitee.EventId);
                string EventName = EventEntity.EnglishName;
                //string DataToSendIntoQR = $"{NewGroupInvitee.Id}/Group/{EventName}";
                //string QRCodeImagePath = await _QRCodeGenerator.GenerateQRCode(DataToSendIntoQR, Request.ImagePath!);
                //byte[] QRCodeBytes = File.ReadAllBytes(QRCodeImagePath);
                //string QRbase64String = Convert.ToBase64String(QRCodeBytes);

                // Generate BarCode..
                string DataToSendIntoBarCode = $"{NewGroupInvitee.UniqueIntegerId}";
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

                DateTime GregorianDate = new DateTime(EventEntity.StartDate.Year, EventEntity.StartDate.Month,
                    EventEntity.StartDate.Day, EventEntity.StartDate.Hour, EventEntity.StartDate.Minute, EventEntity.StartDate.Second);

                string ManipulatedBody = HTMLContent
                    .Replace("$NewInvitee.Name$", NewGroupInvitee.Name, StringComparison.Ordinal) // Invited Name..
                    .Replace("$EventEntity.EnglishName$", EventEntity.EnglishName, StringComparison.Ordinal) // Event Name in English..
                    .Replace("$EventEntity.EnglishLocation$", EventEntity.EnglishSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                    .Replace("$EventEntity.StartDate.DayOfWeek$", EventEntity.StartDate.DayOfWeek.ToString(), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                    .Replace("$EventEntity.StartDate.Date$", GregorianDate.ToString("M/d/yyyy")) // Event Date..
                    .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("HH:mm:ss")) // Event Time..
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
                    ToEmail = NewGroupInvitee.Email,
                    Subject = $"Group Invitation to attend {EventEntity.EnglishName}",
                    Body = ManipulatedBody,
                };

                await _EmailSender.SendEmail(EmailRequest, AlternateView);

                try
                {
                    NewGroupInvitee = await _groupInviteeRepository.AddAsync(NewGroupInvitee);
                }
                catch (DbUpdateException)
                {
                    throw;
                }
            }

            return Unit.Value;
        }
    }
}
