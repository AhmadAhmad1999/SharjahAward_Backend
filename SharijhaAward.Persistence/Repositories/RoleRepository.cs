using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Repositories
{
    public class RoleRepository : BaseRepository<Domain.Entities.IdentityModels.Role> , IRoleRepository
    {
        public RoleRepository (SharijhaAwardDbContext dbContext) : base(dbContext) 
        {
        }
    }
}
