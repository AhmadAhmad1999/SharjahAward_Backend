using AutoMapper;
using FluentValidation;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee
{
    public class CreateGroupInviteeCommandHandler
        : IRequestHandler<CreateGroupInviteeCommand, Unit>
    {
        private readonly IAsyncRepository<GroupInvitee> _groupInviteeRepository;
        private readonly IMapper _mapper;
        public CreateGroupInviteeCommandHandler(IAsyncRepository<GroupInvitee> groupInviteeRepository, IMapper mapper)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _mapper = mapper;
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
            return Unit.Value;
        }
    }
}
