using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Persistence.Repositories
{
    public class RoleRepository : BaseRepository<Domain.Entities.IdentityModels.Role> , IRoleRepository
    {
        public RoleRepository (SharijhaAwardDbContext dbContext) : base(dbContext) 
        {
        }

        public async Task<Role> GetByName(string name)
        {
            var role = await _dbContext.Roles.FirstOrDefaultAsync(r => r.EnglishName.ToLower() == name.ToLower());
            return role!; 
        }
    }
}
