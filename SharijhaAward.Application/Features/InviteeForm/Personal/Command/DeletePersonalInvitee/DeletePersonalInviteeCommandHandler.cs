using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Command.DeletePersonalInvitee
{
    public class DeletePersonalInviteeCommandHandler
        : IRequestHandler<DeletePersonalInviteeCommand, Unit>
    {
        private readonly IAsyncRepository<PersonalInvitee> _PersonalInviteeRepository;
        private readonly IMapper _mapper;
        public DeletePersonalInviteeCommandHandler(IAsyncRepository<PersonalInvitee> personalInviteeRepository, IMapper mapper)
        {
            _PersonalInviteeRepository = personalInviteeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeletePersonalInviteeCommand request, CancellationToken cancellationToken)
        {
            var personalToDelete = await _PersonalInviteeRepository.GetByIdAsync(request.Id);
            if (personalToDelete == null)
            {
                throw new OpenQA.Selenium.NotFoundException();
            }
            
            await _PersonalInviteeRepository.DeleteAsync(personalToDelete);
            return Unit.Value;
        }
    }
}
