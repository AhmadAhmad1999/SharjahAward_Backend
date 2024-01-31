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

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee
{
    public class CreatePersonalInviteeCommandHandler
        : IRequestHandler<
            CreatePersonalInviteeCommand,
            Guid>
    {
        private readonly IAsyncRepository<PersonalInvitee> _PersonalInviteeRepository;
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository;
        private readonly IMapper _mapper;
        private IEmailSender _EmailSender;
        private IQRCodeGenerator _QRCodeGenerator;

        public CreatePersonalInviteeCommandHandler(IAsyncRepository<PersonalInvitee> personalInviteeRepository, IMapper mapper,
            IQRCodeGenerator QRCodeGenerator,
            IAsyncRepository<Domain.Entities.EventModel.Event> EventRepository,
            IEmailSender EmailSender)
        {
            _PersonalInviteeRepository = personalInviteeRepository;
            _mapper = mapper;
            _QRCodeGenerator = QRCodeGenerator;
            _EventRepository = EventRepository;
            _EmailSender = EmailSender;
        }

        public async Task<Guid> Handle(CreatePersonalInviteeCommand request, CancellationToken cancellationToken)
        {
            CreatePersonalInviteeCommandValidator? Validator = new CreatePersonalInviteeCommandValidator();
            FluentValidation.Results.ValidationResult? ValidationResult = await Validator.ValidateAsync(request, cancellationToken);

            if (ValidationResult.Errors.Count > 0)
                throw new FluentValidation.ValidationException(ValidationResult.Errors);

            PersonalInvitee? NewPersonalnvitee = _mapper.Map<PersonalInvitee>(request);
            NewPersonalnvitee = await _PersonalInviteeRepository.AddAsync(NewPersonalnvitee);

            if (!string.IsNullOrEmpty(request.lang) 
                ? request.lang.ToLower() == "ar" 
                : false)
            {
                // Generate QR Code..
                Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(NewPersonalnvitee.EventId);
                string EventName = EventEntity.ArabicName;
                string DataToSendIntoQR = $"{NewPersonalnvitee.Id}/Personal/{EventName}";
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
                    .Replace("$NewInvitee.Name$", NewPersonalnvitee.Name, StringComparison.Ordinal) // Invited Name..
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
                    ToEmail = NewPersonalnvitee.Email,
                    Subject = $"دعوة فردية لحضور {EventEntity.ArabicName}",
                    Body = ManipulatedBody,
                };

                await _EmailSender.SendEmail(EmailRequest, QRCodeImagePath);

                return NewPersonalnvitee.Id;
            }
            else
            {
                // Generate QR Code..
                Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(NewPersonalnvitee.EventId);
                string EventName = EventEntity.EnglishName;
                string DataToSendIntoQR = $"{NewPersonalnvitee.Id}/Personal/{EventName}";
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
                    .Replace("$NewInvitee.Name$", NewPersonalnvitee.Name, StringComparison.Ordinal) // Invited Name..
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
                    ToEmail = NewPersonalnvitee.Email,
                    Subject = $"Personal Invitation to attend {EventEntity.EnglishName}",
                    Body = ManipulatedBody,
                };

                await _EmailSender.SendEmail(EmailRequest, QRCodeImagePath);

                return NewPersonalnvitee.Id;
            }
        }
    }
}
