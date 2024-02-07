using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Contract.Persistence
{
    public interface IPersonalInviteeRepository : IAsyncRepository<PersonalInvitee>
    {
        public Task ConfirmationofAttendance(PersonalInvitee personal);
        public Task<PersonalInvitee> GetByInviteeNumber(int inviteeNumber);
    }
}