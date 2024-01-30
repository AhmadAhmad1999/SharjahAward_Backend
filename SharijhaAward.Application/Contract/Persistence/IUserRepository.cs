using SharijhaAward.Domain.Model.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Contract.Persistence
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        public Task<User> GetByEmailAsync(string email);
        public Task<string> LogInAsync(User user);
        public Task<string> RegisterAsync(User user);
    }
}
