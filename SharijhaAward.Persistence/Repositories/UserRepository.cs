using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Authentication;
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

        public async Task ChangePassword(Guid Id, string password)
        {
            var user =await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == Id);
            user!.Password= password;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            User? user = await _dbContext.Users
                .FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());
            return user;
        }

        public async Task<AuthenticationResponse> LogInAsync(User user)
        {
            User? userToLogin = await GetByEmailAsync(user.Email);
            if (userToLogin == null)
            {
                return new AuthenticationResponse()
                {
                    message = "User Not Found"
                };
            }
            if (userToLogin.Password == user.Password)
            {
                var token = _jwtProvider.Generate(userToLogin);
                userToLogin.Role = await _dbContext.Roles.FindAsync(userToLogin.RoleId);
                // var permissions = await _dbContext.RolePermissions.FindAsync(userToLogin.Role.RolePermissionId);

                var response = new AuthenticationResponse()
                {
                    token = token,
                    user = userToLogin,
                    //permissions = permissions.Permission
                    message = "Login Sucsses"
                };
                return response;
            }
            return new AuthenticationResponse()
            {
                message = "Authentication Error"
            };
           
        }

        public async Task<string> RegisterAsync(User user)
        {
            if (user != null)
            {
                string token =  _jwtProvider.Generate(user);
                return token;
            }
            throw new Exception("The Account is not created");
        }
    }
}
