using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Contract.Persistence
{
    public interface IGroupInviteeRepository : IAsyncRepository<GroupInvitee>
    {
        public Task ConfirmationofAttendance(GroupInvitee group , int NumberOfAttendees); 
        public Task<GroupInvitee> GetByInviteeNumber(int inviteeNumber);
    }
}
