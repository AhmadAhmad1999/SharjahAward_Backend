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
                string DownloadedHTMLFileName = Guid.NewGuid().ToString() + ".html";
                string DownloadedHTMLFilePath = Request.ImagePath + "\\HTMLCodes\\" + DownloadedHTMLFileName;
                //string DownloadQRImageAPI = isHttps
                //    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadQRCode?QRCodeName={QRCodeImagePath.Split('/').LastOrDefault()}" +
                //        $"&EventName={EventEntity.ArabicName}"
                //    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadQRCode?QRCodeName={QRCodeImagePath.Split('/').LastOrDefault()}" +
                //        $"&EventName={EventEntity.ArabicName}";

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

                string BarCodeImageURL = isHttps
                   ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}"
                   : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}";

                byte[] Email_HeaderImageBytes = File.ReadAllBytes("wwwroot/assets/qr/email_header.png");
                string Email_HeaderImagebase64String = Convert.ToBase64String(Email_HeaderImageBytes);

                byte[] LogosImageImageBytes = File.ReadAllBytes("wwwroot/assets/qr/logos.png");
                string LogosImageImagebase64String = Convert.ToBase64String(LogosImageImageBytes);

                byte[] BarCodeImageImageBytes = File.ReadAllBytes(BarCodeImagePath);
                string BarCodeImagebase64String = Convert.ToBase64String(BarCodeImageImageBytes);

                byte[] CaligraphyImageImageBytes = File.ReadAllBytes("wwwroot/assets/qr/caligraphy.png");
                string CaligraphyImagebase64String = Convert.ToBase64String(CaligraphyImageImageBytes);

                string ManipulatedBodyForPdf = ManipulatedBody
                    .Replace("\"cid:Email_HeaderImage\"", $"'data:image/png;base64,{Email_HeaderImagebase64String}'")
                    .Replace("\"cid:LogosImage\"", $"'data:image/png;base64,{LogosImageImagebase64String}'")
                    .Replace("\"cid:BarCodeImage\"", $"'data:image/png;base64,{BarCodeImagebase64String}'")
                    .Replace("'cid:CaligraphyImage'", $"'data:image/png;base64,{CaligraphyImagebase64String}'");

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
                CultureInfo EnglishCulture = new CultureInfo("en-US");
                //string DownloadQRImageAPI = isHttps
                //    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadQRCode?QRCodeName={QRCodeImagePath.Split('/').LastOrDefault()}" +
                //        $"&EventName={EventEntity.ArabicName}"
                //    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadQRCode?QRCodeName={QRCodeImagePath.Split('/').LastOrDefault()}" +
                //        $"&EventName={EventEntity.ArabicName}";
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
                    .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("HH:mm tt", EnglishCulture)) // Event Time..
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

                string BarCodeImageURL = isHttps
                  ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}"
                  : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}";

                byte[] Email_HeaderImageBytes = File.ReadAllBytes("wwwroot/assets/qr/email_header.png");
                string Email_HeaderImagebase64String = Convert.ToBase64String(Email_HeaderImageBytes);

                byte[] LogosImageImageBytes = File.ReadAllBytes("wwwroot/assets/qr/logos.png");
                string LogosImageImagebase64String = Convert.ToBase64String(LogosImageImageBytes);

                byte[] BarCodeImageImageBytes = File.ReadAllBytes(BarCodeImagePath);
                string BarCodeImagebase64String = Convert.ToBase64String(BarCodeImageImageBytes);

                byte[] CaligraphyImageImageBytes = File.ReadAllBytes("wwwroot/assets/qr/caligraphy.png");
                string CaligraphyImagebase64String = Convert.ToBase64String(CaligraphyImageImageBytes);

                string ManipulatedBodyForPdf = ManipulatedBody
                    .Replace("\"cid:Email_HeaderImage\"", $"'data:image/png;base64,{Email_HeaderImagebase64String}'")
                    .Replace("\"cid:LogosImage\"", $"'data:image/png;base64,{LogosImageImagebase64String}'")
                    .Replace("\"cid:BarCodeImage\"", $"'data:image/png;base64,{BarCodeImagebase64String}'")
                    .Replace("'cid:CaligraphyImage'", $"'data:image/png;base64,{CaligraphyImagebase64String}'");

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
