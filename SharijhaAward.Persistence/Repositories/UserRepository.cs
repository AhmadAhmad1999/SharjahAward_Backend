using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly IJwtProvider _jwtProvider;
        
        public UserRepository(SharijhaAwardDbContext dbContext , IJwtProvider jwtProvider) : base(dbContext)
        {
            _jwtProvider = jwtProvider;
        }

        public async Task AsignRole(Guid userId, Guid roleId)
        {
            var role = await _dbContext.Roles.Where(r => r.RoleId == roleId).FirstOrDefaultAsync();
            var user = await _dbContext.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
           
            if (user != null && role != null)
            {
                user.RoleId = roleId;
                user.Role = role;
                role.Users.Add(user);
            }
            await _dbContext.SaveChangesAsync();
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            var user = await _dbContext.Users.Where(u => u.Email == email).FirstAsync();
            if (user == null)
            {
                throw new OpenQA.Selenium.NotFoundException();
            }
            return user;
        }

        public async Task<string> LogInAsync(User user)
        {
           var userToLogin = await GetByEmailAsync(user.Email);
            if(userToLogin.Password==user.Password)
            {
                var token = _jwtProvider.Generate(userToLogin);
                return token;
            }
            return "";
        }

        public async Task<string> RegisterAsync(User user)
        {
            if (user != null)
            {
                string token = _jwtProvider.Generate(user);
                return token;
            }
            else return "";
        }
    }
}
