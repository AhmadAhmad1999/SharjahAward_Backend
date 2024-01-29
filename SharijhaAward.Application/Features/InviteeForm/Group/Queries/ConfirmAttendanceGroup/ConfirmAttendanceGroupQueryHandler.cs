using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.ConfirmAttendanceGroup
{
    public class ConfirmAttendanceGroupQueryHandler
        : IRequestHandler<ConfirmAttendanceGroupQuery, Unit>
    {
        private readonly IGroupInviteeRepository _groupInviteeRepository;
        public ConfirmAttendanceGroupQueryHandler(IGroupInviteeRepository groupInviteeRepository)
        {
            _groupInviteeRepository = groupInviteeRepository;
        }

        public async Task<Unit> Handle(ConfirmAttendanceGroupQuery request, CancellationToken cancellationToken)
        {
            var group = await _groupInviteeRepository.GetByIdAsync(request.Id);
            if (group == null)
            {
               throw new OpenQA.Selenium.NotFoundException();
            }

            await _groupInviteeRepository.ConfirmationofAttendance(group, request.NumberOfAttendees);
            return Unit.Value;
        }
    }
}
