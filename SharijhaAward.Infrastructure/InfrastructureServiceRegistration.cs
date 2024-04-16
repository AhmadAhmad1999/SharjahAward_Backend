using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NPOI.SS.Formula.Functions;
using Org.BouncyCastle.Asn1.X509.Qualified;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Infrastructure.Authentication;
using SharijhaAward.Infrastructure.EmailSernder;
using SharijhaAward.Infrastructure.ExcelHelper;
using SharijhaAward.Infrastructure.FileServices;
using SharijhaAward.Infrastructure.JobServices;
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
            services.AddScoped<IFileService, FileService>();
            services.AddScoped(typeof(IExcelHelper<>), typeof(ExcelHelper<>));
            //services.AddHostedService<BackGroundJobService>();



            return services;
        }
    }
}
