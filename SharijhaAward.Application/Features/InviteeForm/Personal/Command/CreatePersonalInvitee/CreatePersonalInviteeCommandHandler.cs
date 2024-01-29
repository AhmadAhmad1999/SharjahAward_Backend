using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalInviteeById;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee
{
    public class CreatePersonalInviteeCommandHandler
        : IRequestHandler<
            CreatePersonalInviteeCommand,
            Guid>
    {
        private readonly IAsyncRepository<PersonalInvitee> _PersonalInviteeRepository;
        private readonly IMapper _mapper;

        public CreatePersonalInviteeCommandHandler(IAsyncRepository<PersonalInvitee> personalInviteeRepository, IMapper mapper)
        {
            _PersonalInviteeRepository = personalInviteeRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreatePersonalInviteeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreatePersonalInviteeCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count>0)
            {
                throw new FluentValidation.ValidationException(validationResult.Errors);
            }
            var NewPersonalnvitee = _mapper.Map<PersonalInvitee>(request);
            NewPersonalnvitee = await _PersonalInviteeRepository.AddAsync(NewPersonalnvitee);

            

            return NewPersonalnvitee.Id;
        }
    }
}
