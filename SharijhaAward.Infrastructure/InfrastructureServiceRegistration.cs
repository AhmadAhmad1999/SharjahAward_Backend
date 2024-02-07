using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Infrastructure.Authentication;
using SharijhaAward.Infrastructure.EmailSernder;
using SharijhaAward.Infrastructure.QRGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJwtProvider, JwtProvider>();
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<IEmailCodesGenerator,EmailCodesGenerator>();

            return services;
        }
    }
}
