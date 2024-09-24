using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalInviteeById;
using SharijhaAward.Application.Models;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using QRCoder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net.Mime;
using System;
using System.Globalization;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using IronBarCode;
using System.Text.RegularExpressions;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee
{
    public class CreatePersonalInviteeCommandHandler
        : IRequestHandler<
            CreatePersonalInviteeCommand,
            CreateInviteeResponse>
    {
        private readonly IAsyncRepository<PersonalInvitee> _PersonalInviteeRepository;
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository;
        private readonly IMapper _mapper;
        private IEmailSender _EmailSender;
        private IEmailCodesGenerator _QRCodeGenerator;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public CreatePersonalInviteeCommandHandler(IAsyncRepository<PersonalInvitee> personalInviteeRepository, IMapper mapper,
            IEmailCodesGenerator QRCodeGenerator,
            IAsyncRepository<Domain.Entities.EventModel.Event> EventRepository,
            IEmailSender EmailSender,
            IHttpContextAccessor HttpContextAccessor)
        {
            _PersonalInviteeRepository = personalInviteeRepository;
            _mapper = mapper;
            _QRCodeGenerator = QRCodeGenerator;
            _EventRepository = EventRepository;
            _EmailSender = EmailSender;
            _HttpContextAccessor = HttpContextAccessor;
        }

        public async Task<CreateInviteeResponse> Handle(CreatePersonalInviteeCommand Request, CancellationToken CancellationToken)
        {
            CreatePersonalInviteeCommandValidator? Validator = new CreatePersonalInviteeCommandValidator();
            FluentValidation.Results.ValidationResult? ValidationResult = await Validator.ValidateAsync(Request, CancellationToken);

            if (ValidationResult.Errors.Count > 0)
                throw new FluentValidation.ValidationException(ValidationResult.Errors);

            PersonalInvitee? NewPersonalnvitee = _mapper.Map<PersonalInvitee>(Request);
            IEnumerable<int> ListOfUniqueIntegerId = _PersonalInviteeRepository.ListAllAsync()
                .Result.Select(x => x.UniqueIntegerId);

            Random Random = new Random();
            int UniqueIntegerId;
            do
            {
                UniqueIntegerId = Random.Next(100000000, 999999999);
            } while (ListOfUniqueIntegerId.Contains(UniqueIntegerId));

            NewPersonalnvitee.UniqueIntegerId = UniqueIntegerId;

            if (!string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() == "ar"
                : false)
            {
                Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(NewPersonalnvitee.EventId);

                // Generate BarCode..
                string DataToSendIntoBarCode = $"{NewPersonalnvitee.UniqueIntegerId}";
                string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.ImagePath!);

                // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                string HtmlBody = "wwwroot/QREmail_ar.html";

                string HTMLContent = File.ReadAllText(HtmlBody);

                CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                string DownloadedHTMLFileName = Guid.NewGuid().ToString() + ".html";
                string DownloadedHTMLFilePath = Request.ImagePath + "\\HTMLCodes\\" + DownloadedHTMLFileName;

                string DownloadBarCodeImageAPI = isHttps
                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}"
                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}";

                DateTime GregorianDate = new DateTime(EventEntity.EventDate.Year, EventEntity.EventDate.Month,
                    EventEntity.EventDate.Day, EventEntity.EventDate.Hour, EventEntity.EventDate.Minute, EventEntity.EventDate.Second);

                string ManipulatedBody = HTMLContent
                    .Replace("$NewInvitee.Name$", NewPersonalnvitee.Name, StringComparison.Ordinal) // Invited Name..
                    .Replace("$EventEntity.ArabicName$", EventEntity.ArabicName, StringComparison.Ordinal) // Event Name in Arabic..
                    .Replace("$EventEntity.ArabicLocation$", EventEntity.ArabicSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                    .Replace("$EventEntity.StartDate.DayOfWeek$", GregorianDate.ToString("dddd", ArabicCulture), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                    .Replace("$EventEntity.StartDate.Date$", GregorianDate.ToString("d/M/yyyy", ArabicCulture)) // Event Date..
                    .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("hh:mm tt", ArabicCulture)) // Event Time..
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
                    ToEmail = NewPersonalnvitee.Email,
                    Subject = $"دعوة فردية لحضور {EventEntity.ArabicName}",
                    Body = ManipulatedBody,
                };

                string BarCodeImageURL = isHttps
                   ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}"
                   : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}";

                byte[] BarCodeImageImageBytes = File.ReadAllBytes(BarCodeImagePath);
                string BarCodeImagebase64String = Convert.ToBase64String(BarCodeImageImageBytes);

                byte[] HeaderImageBytes = File.ReadAllBytes("wwwroot/assets/qr/header.png");
                string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                string ManipulatedBodyForPdf = ManipulatedBody
                    .Replace("\"cid:BarCodeImage\"", $"'data:image/png;base64,{BarCodeImagebase64String}'")
                    .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                var ManipulatedBodyForPdfSpliter = ManipulatedBodyForPdf.Split("<!--here-->").ToList();
                ManipulatedBodyForPdf = ManipulatedBodyForPdfSpliter[0] + ManipulatedBodyForPdfSpliter[2];

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
                        NewPersonalnvitee = await _PersonalInviteeRepository.AddAsync(NewPersonalnvitee);

                        await _EmailSender.SendEmail(EmailRequest, AlternateView);
                        File.WriteAllText(DownloadedHTMLFilePath, ManipulatedBodyForPdf);

                        Transaction.Complete();
                    }
                    catch (DbUpdateException)
                    {
                        Transaction.Dispose();
                        throw;
                    }
                }

                return new CreateInviteeResponse()
                {
                    Name = NewPersonalnvitee.Name,
                    EventName = EventEntity.ArabicName,
                    EventSiteName = EventEntity.ArabicSiteName,
                    EventDayName = GregorianDate.ToString("dddd", ArabicCulture),
                    EventDate = GregorianDate.ToString("d/M/yyyy", ArabicCulture),
                    EventTime = GregorianDate.ToString("hh:mm tt", ArabicCulture),
                    ImageURl = BarCodeImageURL,
                    DownLoadURL = DownloadBarCodeImageAPI,
                    DownloadFileURL = DownloadedHTMLFileName
                };
            }
            else
            {
                Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(NewPersonalnvitee.EventId);

                CultureInfo EnglishCulture = new CultureInfo("en-US");

                // Generate BarCode..
                string DataToSendIntoBarCode = $"{NewPersonalnvitee.UniqueIntegerId}";
                string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.ImagePath!);

                // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                string HtmlBody = "wwwroot/QREmail_en.html";

                string HTMLContent = File.ReadAllText(HtmlBody);

                bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                string DownloadedHTMLFileName = Guid.NewGuid().ToString() + ".html";
                string DownloadedHTMLFilePath = Request.ImagePath + "\\HTMLCodes\\" + DownloadedHTMLFileName;

                string DownloadBarCodeImageAPI = isHttps
                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}"
                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}";

                DateTime GregorianDate = new DateTime(EventEntity.EventDate.Year, EventEntity.EventDate.Month,
                    EventEntity.EventDate.Day, EventEntity.EventDate.Hour, EventEntity.EventDate.Minute, EventEntity.EventDate.Second);

                string ManipulatedBody = HTMLContent
                    .Replace("$NewInvitee.Name$", NewPersonalnvitee.Name, StringComparison.Ordinal) // Invited Name..
                    .Replace("$EventEntity.EnglishName$", EventEntity.EnglishName, StringComparison.Ordinal) // Event Name in English..
                    .Replace("$EventEntity.EnglishLocation$", EventEntity.EnglishSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                    .Replace("$EventEntity.StartDate.DayOfWeek$", GregorianDate.DayOfWeek.ToString(), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                    .Replace("$EventEntity.StartDate.Date$", GregorianDate.ToString("d/M/yyyy", EnglishCulture)) // Event Date..
                    .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("hh:mm tt", EnglishCulture))
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
                    ToEmail = NewPersonalnvitee.Email,
                    Subject = $"Personal Invitation to attend {EventEntity.EnglishName}",
                    Body = ManipulatedBody,
                };

                string BarCodeImageURL = isHttps
                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}"
                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}";

                byte[] BarCodeImageImageBytes = File.ReadAllBytes(BarCodeImagePath);
                string BarCodeImagebase64String = Convert.ToBase64String(BarCodeImageImageBytes);

                byte[] HeaderImageBytes = File.ReadAllBytes("wwwroot/assets/qr/header.png");
                string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                string ManipulatedBodyForPdf = ManipulatedBody
                    .Replace("\"cid:BarCodeImage\"", $"'data:image/png;base64,{BarCodeImagebase64String}'")
                    .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                var ManipulatedBodyForPdfSpliter = ManipulatedBodyForPdf.Split("<!--here-->").ToList();
                ManipulatedBodyForPdf = ManipulatedBodyForPdfSpliter[0] + ManipulatedBodyForPdfSpliter[2];

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
                        NewPersonalnvitee = await _PersonalInviteeRepository.AddAsync(NewPersonalnvitee);

                        await _EmailSender.SendEmail(EmailRequest, AlternateView);
                        File.WriteAllText(DownloadedHTMLFilePath, ManipulatedBodyForPdf);

                        Transaction.Complete();
                    }
                    catch (DbUpdateException)
                    {
                        Transaction.Dispose();
                        throw;
                    }
                }

                return new CreateInviteeResponse()
                {
                    Name = NewPersonalnvitee.Name,
                    EventName = EventEntity.EnglishName,
                    EventSiteName = EventEntity.EnglishSiteName,
                    EventDayName = GregorianDate.DayOfWeek.ToString(),
                    EventDate = GregorianDate.ToString("d/M/yyyy", EnglishCulture),
                    EventTime = GregorianDate.ToString("hh:mm tt", EnglishCulture),
                    ImageURl = BarCodeImageURL,
                    DownLoadURL = DownloadBarCodeImageAPI,
                    DownloadFileURL = DownloadedHTMLFileName
                };
            }
        }
    }
}
