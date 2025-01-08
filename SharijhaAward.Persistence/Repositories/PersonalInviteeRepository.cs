using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;

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
