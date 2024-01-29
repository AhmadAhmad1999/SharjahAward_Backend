using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Repositories
{
    public class GroupInviteeRepository
        : BaseRepository<GroupInvitee>, IGroupInviteeRepository
    {
        public GroupInviteeRepository(SharijhaAwardDbContext dbContext) : base(dbContext)
        {
        }

        public async Task ConfirmationofAttendance(GroupInvitee group , int NumberOfAttendees)
        {
             group.ActualNumberOfAttendees = NumberOfAttendees;
            _dbContext.Entry(group).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
