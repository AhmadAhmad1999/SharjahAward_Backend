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

namespace SharijhaAward.Application.Features.InviteeForm.ResendEmail
{
    internal class ResendEmailQueryHandler
        : IRequestHandler<ResendEmailQuery, Unit>
    {
        private readonly IAsyncRepository<PersonalInvitee> _PersonalInviteeRepository;
        private readonly IAsyncRepository<GroupInvitee> _GroupInviteeRepository;
        private readonly IMapper _Mapper;
        private IEmailSender _EmailSender;
        private IQRCodeGenerator _QRCodeGenerator;
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository;

        public ResendEmailQueryHandler(IAsyncRepository<PersonalInvitee> personalInviteeRepository,
            IMapper mapper,
            IAsyncRepository<GroupInvitee> GroupInviteeRepository,
            IEmailSender EmailSender,
            IQRCodeGenerator QRCodeGenerator,
            IAsyncRepository<Domain.Entities.EventModel.Event> EventRepository)
        {
            _PersonalInviteeRepository = personalInviteeRepository;
            _Mapper = mapper;
            _GroupInviteeRepository = GroupInviteeRepository;
            _EmailSender = EmailSender;
            _QRCodeGenerator = QRCodeGenerator;
            _EventRepository = EventRepository;
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
                    string DataToSendIntoQR = $"{PersonalInvitee.Id}/Personal/{EventName}";
                    string QRCodeImagePath = await _QRCodeGenerator.GenerateQRCode(DataToSendIntoQR);
                    byte[] QRCodeBytes = File.ReadAllBytes(QRCodeImagePath);
                    string QRbase64String = Convert.ToBase64String(QRCodeBytes);

                    string CaligraphyImagePath = "wwwroot/assets/qr/caligraphy.png";
                    byte[] CaligraphyBytes = File.ReadAllBytes(CaligraphyImagePath);
                    string CaligraphyBase64String = Convert.ToBase64String(CaligraphyBytes);

                    string Email_HeaderImagePath = "wwwroot/assets/qr/caligraphy.png";
                    byte[] Email_HeaderBytes = File.ReadAllBytes(Email_HeaderImagePath);
                    string Email_HeaderBase64String = Convert.ToBase64String(Email_HeaderBytes);

                    string LogosImagePath = "wwwroot/assets/qr/logos.png";
                    byte[] LogosBytes = File.ReadAllBytes(LogosImagePath);
                    string LogosBase64String = Convert.ToBase64String(LogosBytes);

                    // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                    string HtmlBody = "wwwroot/QREmail_ar.html";

                    string HTMLContent = File.ReadAllText(HtmlBody);

                    CultureInfo ArabicCulture = new CultureInfo("ar-SA");

                    string ManipulatedBody = HTMLContent
                        .Replace("$NewInvitee.Name$", PersonalInvitee.Name, StringComparison.Ordinal) // Invited Name..
                        .Replace("$EventEntity.ArabicName$", EventEntity.ArabicName, StringComparison.Ordinal) // Event Name in Arabic..
                        .Replace("$EventEntity.ArabicLocation$", EventEntity.ArabicSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.DayOfWeek$", EventEntity.StartDate.ToString("dddd", ArabicCulture), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.Date$", EventEntity.StartDate.ToString("M/d/yyyy", ArabicCulture), StringComparison.Ordinal) // Event Date..
                        .Replace("$EventEntity.StartDate.TimeOfDay$", EventEntity.StartDate.ToString("HH:mm:ss", ArabicCulture), StringComparison.Ordinal) // Event Time..
                        .Replace("\"./assets/qr/qr.png\"", $"'data:image/png;base64,{QRbase64String}'") // QR Code Image Path..
                        .Replace("\"./assets/qr/caligraphy.png\"", $"'data:image/png;base64,{CaligraphyBase64String}'") // Caligraphy Image..
                        .Replace("\"./assets/qr/email_header.png\"", $"'data:image/png;base64,{Email_HeaderBase64String}'") // Email_Header Image..
                        .Replace("\"./assets/qr/logos.png\"", $"'data:image/png;base64,{LogosBase64String}'"); // Logos Image..

                    EmailRequest EmailRequest = new EmailRequest()
                    {
                        ToEmail = PersonalInvitee.Email,
                        Subject = $"دعوة فردية لحضور {EventEntity.ArabicName}",
                        Body = ManipulatedBody,
                    };

                    await _EmailSender.SendEmail(EmailRequest);

                    return Unit.Value;
                }
                else
                {
                    // Generate QR Code..
                    Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(PersonalInvitee.EventId);
                    string EventName = EventEntity.EnglishName;
                    string DataToSendIntoQR = $"{PersonalInvitee.Id}/Personal/{EventName}";
                    string QRCodeImagePath = await _QRCodeGenerator.GenerateQRCode(DataToSendIntoQR);
                    byte[] QRCodeBytes = File.ReadAllBytes(QRCodeImagePath);
                    string QRbase64String = Convert.ToBase64String(QRCodeBytes);

                    string CaligraphyImagePath = "wwwroot/assets/qr/caligraphy.png";
                    byte[] CaligraphyBytes = File.ReadAllBytes(CaligraphyImagePath);
                    string CaligraphyBase64String = Convert.ToBase64String(CaligraphyBytes);

                    string Email_HeaderImagePath = "wwwroot/assets/qr/caligraphy.png";
                    byte[] Email_HeaderBytes = File.ReadAllBytes(Email_HeaderImagePath);
                    string Email_HeaderBase64String = Convert.ToBase64String(Email_HeaderBytes);

                    string LogosImagePath = "wwwroot/assets/qr/logos.png";
                    byte[] LogosBytes = File.ReadAllBytes(LogosImagePath);
                    string LogosBase64String = Convert.ToBase64String(LogosBytes);

                    // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                    string HtmlBody = "wwwroot/QREmail_en.html";

                    string HTMLContent = File.ReadAllText(HtmlBody);

                    string ManipulatedBody = HTMLContent
                        .Replace("$NewInvitee.Name$", PersonalInvitee.Name, StringComparison.Ordinal) // Invited Name..
                        .Replace("$EventEntity.EnglishName$", EventEntity.EnglishName, StringComparison.Ordinal) // Event Name in English..
                        .Replace("$EventEntity.EnglishLocation$", EventEntity.EnglishSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.DayOfWeek$", EventEntity.StartDate.DayOfWeek.ToString(), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.Date$", EventEntity.StartDate.ToString("M/d/yyyy"), StringComparison.Ordinal) // Event Date..
                        .Replace("$EventEntity.StartDate.TimeOfDay$", EventEntity.StartDate.ToString("HH:mm:ss"), StringComparison.Ordinal) // Event Time..
                        .Replace("\"./assets/qr/qr.png\"", $"'data:image/png;base64,{QRbase64String}'") // QR Code Image Path..
                        .Replace("\"./assets/qr/caligraphy.png\"", $"'data:image/png;base64,{CaligraphyBase64String}'") // Caligraphy Image..
                        .Replace("\"./assets/qr/email_header.png\"", $"'data:image/png;base64,{Email_HeaderBase64String}'") // Email_Header Image..
                        .Replace("\"./assets/qr/logos.png\"", $"'data:image/png;base64,{LogosBase64String}'"); // Logos Image..

                    EmailRequest EmailRequest = new EmailRequest()
                    {
                        ToEmail = PersonalInvitee.Email,
                        Subject = $"Personal Invitation to attend {EventEntity.EnglishName}",
                        Body = ManipulatedBody,
                    };

                    await _EmailSender.SendEmail(EmailRequest);

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
                    string DataToSendIntoQR = $"{GroupInvitee.Id}/Group/{EventName}";
                    string QRCodeImagePath = await _QRCodeGenerator.GenerateQRCode(DataToSendIntoQR);
                    byte[] QRCodeBytes = File.ReadAllBytes(QRCodeImagePath);
                    string QRbase64String = Convert.ToBase64String(QRCodeBytes);

                    string CaligraphyImagePath = "wwwroot/assets/qr/caligraphy.png";
                    byte[] CaligraphyBytes = File.ReadAllBytes(CaligraphyImagePath);
                    string CaligraphyBase64String = Convert.ToBase64String(CaligraphyBytes);

                    string Email_HeaderImagePath = "wwwroot/assets/qr/caligraphy.png";
                    byte[] Email_HeaderBytes = File.ReadAllBytes(Email_HeaderImagePath);
                    string Email_HeaderBase64String = Convert.ToBase64String(Email_HeaderBytes);

                    string LogosImagePath = "wwwroot/assets/qr/logos.png";
                    byte[] LogosBytes = File.ReadAllBytes(LogosImagePath);
                    string LogosBase64String = Convert.ToBase64String(LogosBytes);

                    // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                    string HtmlBody = "wwwroot/QREmail_ar.html";

                    string HTMLContent = File.ReadAllText(HtmlBody);

                    CultureInfo ArabicCulture = new CultureInfo("ar-SA");

                    string ManipulatedBody = HTMLContent
                        .Replace("$NewInvitee.Name$", GroupInvitee.Name, StringComparison.Ordinal) // Invited Name..
                        .Replace("$EventEntity.ArabicName$", EventEntity.ArabicName, StringComparison.Ordinal) // Event Name in Arabic..
                        .Replace("$EventEntity.ArabicLocation$", EventEntity.ArabicSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.DayOfWeek$", EventEntity.StartDate.ToString("dddd", ArabicCulture), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.Date$", EventEntity.StartDate.ToString("M/d/yyyy", ArabicCulture), StringComparison.Ordinal) // Event Date..
                        .Replace("$EventEntity.StartDate.TimeOfDay$", EventEntity.StartDate.ToString("HH:mm:ss", ArabicCulture), StringComparison.Ordinal) // Event Time..
                        .Replace("\"./assets/qr/qr.png\"", $"'data:image/png;base64,{QRbase64String}'") // QR Code Image Path..
                        .Replace("\"./assets/qr/caligraphy.png\"", $"'data:image/png;base64,{CaligraphyBase64String}'") // Caligraphy Image..
                        .Replace("\"./assets/qr/email_header.png\"", $"'data:image/png;base64,{Email_HeaderBase64String}'") // Email_Header Image..
                        .Replace("\"./assets/qr/logos.png\"", $"'data:image/png;base64,{LogosBase64String}'"); // Logos Image..

                    EmailRequest EmailRequest = new EmailRequest()
                    {
                        ToEmail = GroupInvitee.Email,
                        Subject = $"دعوة جماعية لحضور {EventEntity.ArabicName}",
                        Body = ManipulatedBody,
                    };

                    await _EmailSender.SendEmail(EmailRequest);

                    return Unit.Value;
                }
                else
                {
                    // Generate QR Code..
                    Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(GroupInvitee.EventId);
                    string EventName = EventEntity.EnglishName;
                    string DataToSendIntoQR = $"{GroupInvitee.Id}/Group/{EventName}";
                    string QRCodeImagePath = await _QRCodeGenerator.GenerateQRCode(DataToSendIntoQR);
                    byte[] QRCodeBytes = File.ReadAllBytes(QRCodeImagePath);
                    string QRbase64String = Convert.ToBase64String(QRCodeBytes);

                    string CaligraphyImagePath = "wwwroot/assets/qr/caligraphy.png";
                    byte[] CaligraphyBytes = File.ReadAllBytes(CaligraphyImagePath);
                    string CaligraphyBase64String = Convert.ToBase64String(CaligraphyBytes);

                    string Email_HeaderImagePath = "wwwroot/assets/qr/caligraphy.png";
                    byte[] Email_HeaderBytes = File.ReadAllBytes(Email_HeaderImagePath);
                    string Email_HeaderBase64String = Convert.ToBase64String(Email_HeaderBytes);

                    string LogosImagePath = "wwwroot/assets/qr/logos.png";
                    byte[] LogosBytes = File.ReadAllBytes(LogosImagePath);
                    string LogosBase64String = Convert.ToBase64String(LogosBytes);

                    // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                    string HtmlBody = "wwwroot/QREmail_en.html";

                    string HTMLContent = File.ReadAllText(HtmlBody);

                    string ManipulatedBody = HTMLContent
                        .Replace("$NewInvitee.Name$", GroupInvitee.Name, StringComparison.Ordinal) // Invited Name..
                        .Replace("$EventEntity.EnglishName$", EventEntity.EnglishName, StringComparison.Ordinal) // Event Name in English..
                        .Replace("$EventEntity.EnglishLocation$", EventEntity.EnglishSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.DayOfWeek$", EventEntity.StartDate.DayOfWeek.ToString(), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                        .Replace("$EventEntity.StartDate.Date$", EventEntity.StartDate.ToString("M/d/yyyy"), StringComparison.Ordinal) // Event Date..
                        .Replace("$EventEntity.StartDate.TimeOfDay$", EventEntity.StartDate.ToString("HH:mm:ss"), StringComparison.Ordinal) // Event Time..
                        .Replace("\"./assets/qr/qr.png\"", $"'data:image/png;base64,{QRbase64String}'") // QR Code Image Path..
                        .Replace("\"./assets/qr/caligraphy.png\"", $"'data:image/png;base64,{CaligraphyBase64String}'") // Caligraphy Image..
                        .Replace("\"./assets/qr/email_header.png\"", $"'data:image/png;base64,{Email_HeaderBase64String}'") // Email_Header Image..
                        .Replace("\"./assets/qr/logos.png\"", $"'data:image/png;base64,{LogosBase64String}'"); // Logos Image..

                    EmailRequest EmailRequest = new EmailRequest()
                    {
                        ToEmail = GroupInvitee.Email,
                        Subject = $"Group Invitation to attend {EventEntity.EnglishName}",
                        Body = ManipulatedBody,
                    };

                    await _EmailSender.SendEmail(EmailRequest);

                    return Unit.Value;
                }
            }

            return Unit.Value;
        }
    }
}
