using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Command.DeleteGroupInvitee
{
    public class DeleteGroupInviteeCommandHandler
        : IRequestHandler<DeleteGroupInviteeCommand, Unit>
    {
        private readonly IAsyncRepository<GroupInvitee> _groupInviteeRepository;
        private readonly IMapper _mapper;
        public DeleteGroupInviteeCommandHandler(IAsyncRepository<GroupInvitee> groupInviteeRepository, IMapper mapper)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteGroupInviteeCommand request, CancellationToken cancellationToken)
        {
            var GroupInviteeToDelete = await _groupInviteeRepository.GetByIdAsync(request.Id);
            if (GroupInviteeToDelete == null)
            {
                throw new OpenQA.Selenium.NotFoundException();
            }
            await _groupInviteeRepository.DeleteAsync(GroupInviteeToDelete);
            return Unit.Value;
        }
    }
}
