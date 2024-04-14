using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Contract.Persistence
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        public Task<User> GetByEmailAsync(string email, bool intoAdminDashboard);
        public Task<AuthenticationResponse> LogInAsync(User user, string? lang, bool intoAdminDashboard);
        public Task<string> RegisterAsync(User user);
        //public Task AsignRole(int userId, int roleId);
        public Task ChangePassword(int Id,string password);
    }
}
