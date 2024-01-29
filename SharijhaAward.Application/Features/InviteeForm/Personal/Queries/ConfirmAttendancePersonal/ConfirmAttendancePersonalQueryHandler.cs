using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ConfirmAttendancePersonal
{
    public class ConfirmAttendancePersonalQueryHandler
        : IRequestHandler<ConfirmAttendancePersonalQuery, Unit>
    {
        private readonly IPersonalInviteeRepository _personalInviteeRepository;
        public ConfirmAttendancePersonalQueryHandler(IPersonalInviteeRepository personalInviteeRepository)
        {
            _personalInviteeRepository = personalInviteeRepository;
        }

        public async Task<Unit> Handle(ConfirmAttendancePersonalQuery request, CancellationToken cancellationToken)
        {
            PersonalInvitee person = await _personalInviteeRepository.GetByIdAsync(request.Id);
            if (person == null)
            {
                throw new OpenQA.Selenium.NotFoundException();
            }
            await _personalInviteeRepository.ConfirmationofAttendance(person);

            return Unit.Value;
        }
    }
}
