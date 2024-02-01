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

namespace SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee
{
    public class CreateGroupInviteeCommandHandler
        : IRequestHandler<CreateGroupInviteeCommand, Unit>
    {
        private readonly IAsyncRepository<GroupInvitee> _groupInviteeRepository;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository;
        private IEmailSender _EmailSender;
        private IQRCodeGenerator _QRCodeGenerator;
        public CreateGroupInviteeCommandHandler(IAsyncRepository<GroupInvitee> groupInviteeRepository, IMapper mapper,
            IQRCodeGenerator QRCodeGenerator,
            IAsyncRepository<Domain.Entities.EventModel.Event> EventRepository,
            IEmailSender EmailSender)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _mapper = mapper;
            _QRCodeGenerator = QRCodeGenerator;
            _EventRepository = EventRepository;
            _EmailSender = EmailSender;
        }

        public async Task<Unit> Handle(CreateGroupInviteeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateGroupInviteeCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult.Errors);
            }
            var NewGroupInvitee = _mapper.Map<GroupInvitee>(request);
            NewGroupInvitee = await _groupInviteeRepository.AddAsync(NewGroupInvitee);

            if (!string.IsNullOrEmpty(request.lang)
                ? request.lang.ToLower() == "ar"
                : false)
            {
                // Generate QR Code..
                Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(NewGroupInvitee.EventId);
                string EventName = EventEntity.ArabicName;
                string DataToSendIntoQR = $"{NewGroupInvitee.Id}/Group/{EventName}";
                string QRCodeImagePath = await _QRCodeGenerator.GenerateQRCode(DataToSendIntoQR);
                byte[] QRCodeBytes = File.ReadAllBytes(QRCodeImagePath);
                string QRbase64String = Convert.ToBase64String(QRCodeBytes);

                string CaligraphyImagePath = "wwwroot/assets/qr/caligraphy.png";
                byte[] CaligraphyBytes = File.ReadAllBytes(CaligraphyImagePath);
                string CaligraphyBase64String = Convert.ToBase64String(CaligraphyBytes);

                string Email_HeaderImagePath = "wwwroot/assets/qr/email_header.png";
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
                    .Replace("$NewInvitee.Name$", NewGroupInvitee.Name, StringComparison.Ordinal) // Invited Name..
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
                    ToEmail = NewGroupInvitee.Email,
                    Subject = $"دعوة جماعية لحضور {EventEntity.ArabicName}",
                    Body = ManipulatedBody,
                };

                await _EmailSender.SendEmail(EmailRequest);
            }
            else
            {
                // Generate QR Code..
                Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(NewGroupInvitee.EventId);
                string EventName = EventEntity.EnglishName;
                string DataToSendIntoQR = $"{NewGroupInvitee.Id}/Group/{EventName}";
                string QRCodeImagePath = await _QRCodeGenerator.GenerateQRCode(DataToSendIntoQR);
                byte[] QRCodeBytes = File.ReadAllBytes(QRCodeImagePath);
                string QRbase64String = Convert.ToBase64String(QRCodeBytes);

                string CaligraphyImagePath = "wwwroot/assets/qr/caligraphy.png";
                byte[] CaligraphyBytes = File.ReadAllBytes(CaligraphyImagePath);
                string CaligraphyBase64String = Convert.ToBase64String(CaligraphyBytes);

                string Email_HeaderImagePath = "wwwroot/assets/qr/email_header.png";
                byte[] Email_HeaderBytes = File.ReadAllBytes(Email_HeaderImagePath);
                string Email_HeaderBase64String = Convert.ToBase64String(Email_HeaderBytes);

                string LogosImagePath = "wwwroot/assets/qr/logos.png";
                byte[] LogosBytes = File.ReadAllBytes(LogosImagePath);
                string LogosBase64String = Convert.ToBase64String(LogosBytes);

                // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                string HtmlBody = "wwwroot/QREmail_en.html";

                string HTMLContent = File.ReadAllText(HtmlBody);

                string ManipulatedBody = HTMLContent
                    .Replace("$NewInvitee.Name$", NewGroupInvitee.Name, StringComparison.Ordinal) // Invited Name..
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
                    ToEmail = NewGroupInvitee.Email,
                    Subject = $"Group Invitation to attend {EventEntity.EnglishName}",
                    Body = ManipulatedBody,
                };

                await _EmailSender.SendEmail(EmailRequest);
            }

            return Unit.Value;
        }
    }
}
