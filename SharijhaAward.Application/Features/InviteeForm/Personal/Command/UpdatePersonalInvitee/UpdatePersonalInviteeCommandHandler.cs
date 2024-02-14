using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Command.UpdatePersonalInvitee
{
    public class UpdatePersonalInviteeCommandHandler : IRequestHandler<UpdatePersonalInviteeCommand, Unit>
    {
        private readonly IAsyncRepository<PersonalInvitee> _PersonalInviteeRepository;
        private readonly IMapper _mapper;

        public UpdatePersonalInviteeCommandHandler(IAsyncRepository<PersonalInvitee> personalInviteeRepository, IMapper mapper)
        {
            _PersonalInviteeRepository = personalInviteeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdatePersonalInviteeCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdatePersonalInviteeCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if(validationResult.Errors.Count>0)
                throw new FluentValidation.ValidationException(validationResult.Errors);


            var PersonalToUpdate = await _PersonalInviteeRepository.GetByIdAsync(request.Id);
            if (PersonalToUpdate == null)
            {
                throw new OpenQA.Selenium.NotFoundException();
            }
            _mapper.Map(request, PersonalToUpdate, typeof(UpdatePersonalInviteeCommand), typeof(PersonalInvitee));
            await _PersonalInviteeRepository.UpdateAsync(PersonalToUpdate);

            return Unit.Value;
        }
    }
}
