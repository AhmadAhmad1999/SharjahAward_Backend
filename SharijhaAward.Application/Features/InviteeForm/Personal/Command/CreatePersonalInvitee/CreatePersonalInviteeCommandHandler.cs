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
        private IQRCodeGenerator _QRCodeGenerator;
        private IEmailSender _EmailSender;

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

            if (ValidationResult.Errors.Count>0)
                throw new FluentValidation.ValidationException(ValidationResult.Errors);

            PersonalInvitee? NewPersonalnvitee = _mapper.Map<PersonalInvitee>(request);
            NewPersonalnvitee = await _PersonalInviteeRepository.AddAsync(NewPersonalnvitee);

            // Generate QR Code..
            Domain.Entities.EventModel.Event EventEntity = await _EventRepository.GetByIdAsync(NewPersonalnvitee.EventId);
            string EventName = EventEntity.Name;
            string DataToSendIntoQR = $"{NewPersonalnvitee.Id   }/Personal/{EventName}";

            string QRCodeImagePath = await _QRCodeGenerator.GenerateQRCode(DataToSendIntoQR);

            // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
            string HTMLFile = "QREmailHelper/QREmail.html";

            string HTMLContent = File.ReadAllText(HTMLFile);
            string ManipulatedBody = HTMLContent
                .Replace("./assets/qr/qr.png", $"./{QRCodeImagePath}") // QR Code Image Path..
                .Replace("$$", NewPersonalnvitee.Name, StringComparison.Ordinal) // Invited Name..

                // Change The (EventEntity.Name) To (EventEntity.ArabicName)..
                .Replace("$$", EventEntity.Name, StringComparison.Ordinal) // Event Name in Arabic..

                .Replace("$$", EventEntity.StartDate.DayOfWeek.ToString(), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                .Replace("$$", EventEntity.StartDate.Date.ToString(), StringComparison.Ordinal) // Event Date..
                .Replace("$$", EventEntity.StartDate.TimeOfDay.ToString(), StringComparison.Ordinal); // Event Time

            EmailRequest EmailRequest = new EmailRequest()
            {
                ToEmail = NewPersonalnvitee.Email,
                // Change The (EventEntity.Name) To (EventEntity.ArabicName)..
                Subject = $"دعوة فردية لحضور {EventEntity.Name}",
                Body = ManipulatedBody
            };

            await _EmailSender.SendEmail(EmailRequest);

            return NewPersonalnvitee.Id;
        }
    }
}
