using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
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
            var role = await _dbContext.Roles.FirstOrDefaultAsync(r => r.RoleId == roleId);
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
           
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
                .FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower() && u.isValidAccount);
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

            byte[] salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

            string CheckPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: user.Password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            if (CheckPassword == userToLogin.Password)
            {
                var token = _jwtProvider.Generate(userToLogin);
                // userToLogin.Role = await _dbContext.Roles.FindAsync(userToLogin.RoleId);
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
                message = "Authentication error, Wrong password"
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
