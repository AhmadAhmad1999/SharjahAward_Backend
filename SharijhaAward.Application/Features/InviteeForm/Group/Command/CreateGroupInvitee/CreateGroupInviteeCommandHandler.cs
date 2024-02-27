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
using System.Transactions;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee
{
    public class CreateGroupInviteeCommandHandler
        : IRequestHandler<CreateGroupInviteeCommand, CreateInviteeResponse>
    {
        private readonly IAsyncRepository<GroupInvitee> _groupInviteeRepository;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository;
        private IEmailSender _EmailSender;
        private IEmailCodesGenerator _QRCodeGenerator;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IAsyncRepository<Student> _StudentRepository;

        public CreateGroupInviteeCommandHandler(IAsyncRepository<GroupInvitee> groupInviteeRepository, IMapper mapper,
            IEmailCodesGenerator QRCodeGenerator,
            IAsyncRepository<Domain.Entities.EventModel.Event> EventRepository,
            IEmailSender EmailSender,
            IHttpContextAccessor HttpContextAccessor,
            IAsyncRepository<Student> StudentRepository)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _mapper = mapper;
            _QRCodeGenerator = QRCodeGenerator;
            _EventRepository = EventRepository;
            _EmailSender = EmailSender;
            _HttpContextAccessor = HttpContextAccessor;
            _StudentRepository = StudentRepository;
        }

        public async Task<CreateInviteeResponse> Handle(CreateGroupInviteeCommand Request, CancellationToken cancellationToken)
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

            if (!string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() == "ar"
                : false)
            {
                Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(NewGroupInvitee.EventId);

                // Generate BarCode..
                string DataToSendIntoBarCode = $"{NewGroupInvitee.UniqueIntegerId}";
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

                string ManipulatedBody = HTMLContent
                    .Replace("$NewInvitee.Name$", NewGroupInvitee.Name, StringComparison.Ordinal) // Invited Name..
                    .Replace("$EventEntity.ArabicName$", EventEntity.ArabicName, StringComparison.Ordinal) // Event Name in Arabic..
                    .Replace("$EventEntity.ArabicLocation$", EventEntity.ArabicSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                    .Replace("$EventEntity.StartDate.DayOfWeek$", EventEntity.EventDate.ToString("dddd", ArabicCulture), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                    .Replace("$EventEntity.StartDate.Date$", EventEntity.EventDate.ToString("d/M/yyyy", ArabicCulture), StringComparison.Ordinal) // Event Date..
                    .Replace("$EventEntity.StartDate.TimeOfDay$", EventEntity.EventDate.ToString("HH:mm tt", ArabicCulture), StringComparison.Ordinal) // Event Time..
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
                    ToEmail = NewGroupInvitee.Email,
                    Subject = $"دعوة جماعية لحضور {EventEntity.ArabicName}",
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

                List<string>? ManipulatedBodyForPdfSpliter = ManipulatedBodyForPdf.Split("<!--here-->").ToList();
                ManipulatedBodyForPdf = ManipulatedBodyForPdfSpliter[0] + ManipulatedBodyForPdfSpliter[2];

                using (TransactionScope Transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {
                        NewGroupInvitee = await _groupInviteeRepository.AddAsync(NewGroupInvitee);

                        if (Request.StudentNamesAsString != null)
                        {
                            List<Student> Students = Request.StudentNamesAsString.Select(StudentName =>
                                new Student
                                {
                                    StudentName = StudentName,
                                    GroupInviteeId = NewGroupInvitee.Id
                                }).ToList();

                            await _StudentRepository.AddRangeAsync(Students);
                        }

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
                    Name = NewGroupInvitee.Name,
                    EventName = EventEntity.ArabicName,
                    EventSiteName = EventEntity.ArabicSiteName,
                    EventDayName = EventEntity.EventDate.ToString("dddd", ArabicCulture),
                    EventDate = EventEntity.EventDate.ToString("d/M/yyyy", ArabicCulture),
                    EventTime = EventEntity.EventDate.ToString("HH:mm tt", ArabicCulture),
                    ImageURl = BarCodeImageURL,
                    DownLoadURL = DownloadedHTMLFileName,
                    DownloadFileURL = DownloadedHTMLFileName
                };
            }
            else
            {
                Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(NewGroupInvitee.EventId);

                CultureInfo EnglishCulture = new CultureInfo("en-US");

                // Generate BarCode..
                string DataToSendIntoBarCode = $"{NewGroupInvitee.UniqueIntegerId}";
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
                    .Replace("$NewInvitee.Name$", NewGroupInvitee.Name, StringComparison.Ordinal) // Invited Name..
                    .Replace("$EventEntity.EnglishName$", EventEntity.EnglishName, StringComparison.Ordinal) // Event Name in English..
                    .Replace("$EventEntity.EnglishLocation$", EventEntity.EnglishSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                    .Replace("$EventEntity.StartDate.DayOfWeek$", GregorianDate.DayOfWeek.ToString(), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                    .Replace("$EventEntity.StartDate.Date$", GregorianDate.ToString("d/M/yyyy", EnglishCulture)) // Event Date..
                    .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("hh:mm tt", EnglishCulture)) // Event Time..
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
                    ToEmail = NewGroupInvitee.Email,
                    Subject = $"Group Invitation to attend {EventEntity.EnglishName}",
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

                using (TransactionScope Transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {
                        NewGroupInvitee = await _groupInviteeRepository.AddAsync(NewGroupInvitee);

                        if (Request.StudentNamesAsString != null)
                        {
                            List<Student> Students = Request.StudentNamesAsString.Select(StudentName =>
                                new Student
                                {
                                    StudentName = StudentName,
                                    GroupInviteeId = NewGroupInvitee.Id
                                }).ToList();

                            await _StudentRepository.AddRangeAsync(Students);
                        }

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
                    Name = NewGroupInvitee.Name,
                    EventName = EventEntity.EnglishName,
                    EventSiteName = EventEntity.EnglishSiteName,
                    EventDayName = EventEntity.EventDate.DayOfWeek.ToString(),
                    EventDate = EventEntity.EventDate.ToString("d/M/yyyy" , EnglishCulture),
                    EventTime = EventEntity.EventDate.ToString("HH:mm tt", EnglishCulture),
                    ImageURl = BarCodeImageURL,
                    DownLoadURL = DownloadedHTMLFileName,
                    DownloadFileURL = DownloadedHTMLFileName
                };
            }
        }
    }
}
