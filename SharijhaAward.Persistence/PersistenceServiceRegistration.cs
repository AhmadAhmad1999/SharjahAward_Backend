using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SharijhaAwardDbContext>(options =>
                options.UseSqlServer(connectionString: configuration.GetConnectionString("DefaultConnection")));
            
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IPersonalInviteeRepository, PersonalInviteeRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
