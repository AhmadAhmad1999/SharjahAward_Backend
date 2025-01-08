using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Persistence.Repositories;
using SharijhaAward.Persistence.Seeders;

namespace SharijhaAward.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Production Database..
            //services.AddDbContext<SharijhaAwardDbContext>(options =>
            //    options.UseSqlServer(connectionString: configuration.GetConnectionString("PRODConnection")));

            // Default Database..
            services.AddDbContext<SharijhaAwardDbContext>(options =>
                options.UseSqlServer(connectionString: configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("SharijhaAward.Api")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IPersonalInviteeRepository, PersonalInviteeRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IGroupInviteeRepository, GroupInviteeRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ICategoryRepository , CategoryRepository>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<ISeedDatabase, SeedDatabase>();
            services.AddScoped<IChatBotService, ChatBotService>();

            return services;
        }
    }
}
