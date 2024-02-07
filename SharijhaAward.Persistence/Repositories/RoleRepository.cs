using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.IdentityModels;
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

        public async Task<Role> GetByName(string name)
        {
            var role= await _dbContext.Roles.Where(r => r.RoleName.ToLower() == name.ToLower()).FirstOrDefaultAsync();
            return role!; 
        }
    }
}
