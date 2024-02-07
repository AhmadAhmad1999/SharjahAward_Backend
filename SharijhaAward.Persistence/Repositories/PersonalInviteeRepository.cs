using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QRCoder.PayloadGenerator;

namespace SharijhaAward.Persistence.Repositories
{
    public class PersonalInviteeRepository : BaseRepository<PersonalInvitee>, IPersonalInviteeRepository
    {
        public PersonalInviteeRepository(SharijhaAwardDbContext dbContext) : base(dbContext)
        {
        }

        public async Task ConfirmationofAttendance(PersonalInvitee personal)
        {
            personal.IsAttend = true;
            _dbContext.Entry(personal).State= EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<PersonalInvitee> GetByInviteeNumber(int inviteeNumber)
        {
            var personal = await _dbContext.Personalnvitees.Where(p => p.UniqueIntegerId == inviteeNumber).FirstAsync();
            return personal;
        }
    }
}
