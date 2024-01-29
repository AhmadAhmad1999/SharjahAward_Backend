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

namespace SharijhaAward.Application.Features.InviteeForm.Group.Command.UpdateGroupInvitee
{
    public class UpdateGroupInviteeCommandHandler
        : IRequestHandler<UpdateGroupInviteeCommand, Unit>
    {
        private readonly IAsyncRepository<GroupInvitee> _groupInviteeRepository;
        private readonly IMapper _mapper;
        public UpdateGroupInviteeCommandHandler(IAsyncRepository<GroupInvitee> groupInviteeRepository, IMapper mapper)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateGroupInviteeCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateGroupInviteeCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count>0)
            {
                throw new ValidationException(validationResult.Errors);
            }
            var GroupInviteeToUpdate = await _groupInviteeRepository.GetByIdAsync(request.Id);
            if (GroupInviteeToUpdate == null)
            {
                throw new OpenQA.Selenium.NotFoundException();
            }
            await _groupInviteeRepository.UpdateAsync(GroupInviteeToUpdate);
            return Unit.Value;
        }
    }
}
