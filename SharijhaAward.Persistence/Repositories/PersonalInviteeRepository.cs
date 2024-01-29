using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Repositories
{
    public class PersonalInviteeRepository : BaseRepository<PersonalInvitee>, IPersonalInviteeRepository
    {
        public PersonalInviteeRepository(SharijhaAwardDbContext dbContext) : base(dbContext)
        {
        }
    }
}
