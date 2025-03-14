﻿using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;

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
            int ActualNumberOfAttendees = (int)(typeof(GroupInvitee).GetProperty("ActualNumberOfAttendees")!.GetValue(group))! + NumberOfAttendees;
            typeof(GroupInvitee).GetProperty("ActualNumberOfAttendees")!.SetValue(group, ActualNumberOfAttendees);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<GroupInvitee> GetByInviteeNumber(int inviteeNumber)
        {
            var Group = await _dbContext.GroupInvitees.Where(p => p.UniqueIntegerId == inviteeNumber).FirstAsync();
            return Group;
        }
    }
}
