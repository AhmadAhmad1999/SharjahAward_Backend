using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using NLog;
using NLog.Config;
using NLog.Extensions.Logging;
using NLog.Targets;
using NLog.Web;
using SharijhaAward.Api.Logger;
using SharijhaAward.Api.MiddleWares;
using SharijhaAward.Api.OptionsSetup;
using SharijhaAward.Application;
using SharijhaAward.Infrastructure;
using SharijhaAward.Persistence;
using System.Net;

string ResponseMessage = string.Empty;

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddPersistenceServices(builder.Configuration);
    builder.Services.AddInfrastructureServices(builder.Configuration);
    builder.Services.AddApplicationServices();
    builder.Services.AddHttpClient();

    // Enable asynchronous DNS resolution
    ServicePointManager.DnsRefreshTimeout = 0;

    /*------------------------------------------------------------------------------------*/
    /*                              Custom Logging Layout                                 */
    /*------------------------------------------------------------------------------------*/
    
    ConfigurationItemFactory.Default.LayoutRenderers
        .RegisterDefinition("Custom-Layout", typeof(CustomlayoutRenderer));

    builder.Services.AddScoped<LogFilterAttribute>();
    builder.Services.AddSingleton<ILoggerFactory, NLogLoggerFactory>();
    var serviceProvider = builder.Services.BuildServiceProvider();
    builder.Services.AddSingleton(builder.Services);
    builder.Services.AddSingleton(serviceProvider);
    builder.Host.UseNLog();

    string wwwrootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
    string customLogFilePath = Path.Combine(wwwrootPath, "Logs", $"LogFile-{DateTime.Now:yyyy-MM-dd}.log");

    // Load NLog configuration from the NLog.config file
    LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");

    // Update the log file path in the NLog configuration
    var fileTarget = (FileTarget)LogManager.Configuration.FindTargetByName("UsersActionsLog");
    fileTarget.FileName = customLogFilePath;

    // Reconfigure NLog with the updated configuration
    LogManager.ReconfigExistingLoggers();

    /*------------------------------------------------------------------------------------*/



    // Enable connection pooling
    ServicePointManager.DefaultConnectionLimit = 100;

    FirebaseApp.Create(new AppOptions()
    {
        Credential = GoogleCredential.FromFile(Path.Combine(builder.Environment.ContentRootPath, "wwwroot", "FirebaseAccountData.json")),
    });

    //builder.Services.AddControllers()
    //    .AddJsonOptions(options =>
    //    {
    //        options.JsonSerializerOptions.Converters.Add(new DateTimeConverterClass());
    //    });

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Sharijah Award",
            Version = "v1"
        });
        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Description = "Please insert JWT with Bearer into field",
            Name = "Authorization",
            Type = SecuritySchemeType.ApiKey
        });
        
        c.AddSecurityRequirement(new OpenApiSecurityRequirement {
           {
               new OpenApiSecurityScheme
               {
                   Reference = new OpenApiReference
                   {
                         Type = ReferenceType.SecurityScheme,
                         Id = "Bearer"
                   }
               },
              new string[] { }
           }
        });
    });

    //builder.Services.AddHangfire(configuration => configuration
    //               .SetDataCompatibilityLevel(CompatibilityLevel.Version_170).UseSimpleAssemblyNameTypeSerializer()
    //               .UseRecommendedSerializerSettings().UseSqlServerStorage(builder.Configuration.GetConnectionString("DefaultConnection"), new SqlServerStorageOptions
    //               {
    //                   CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
    //                   SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
    //                   QueuePollInterval = TimeSpan.Zero,
    //                   UseRecommendedIsolationLevel = true,
    //                   DisableGlobalLocks = true,
    //               }));

    //builder.Services.AddHangfireServer();
    //builder.Services.AddHostedService<BackgroundService>();

    builder.Services.AddAuthorization();
    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();
    builder.Services.ConfigureOptions<JwtOptionsSetup>();
    builder.Services.ConfigureOptions<JwtBearerOptionsSetup>();
    builder.Services.AddHttpContextAccessor();
    builder.Services.AddLogging();
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
    });

    builder.Services.Configure<FormOptions>(options =>
    {
        options.MultipartBodyLengthLimit = 104857600; // 100 MB
        options.ValueLengthLimit = 104857600; // 100 MB
        options.MemoryBufferThreshold = 1048576; // 1 MB
    });


    var app = builder.Build();


    //using (var scope = app.Services.CreateScope())
    //{
    //    var services = scope.ServiceProvider;
    //    SeedDatabase.Initialize(services);
    //}

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
    }

    //using IServiceScope scope = app.Services.CreateScope();
    //ApplyMigration<SharijhaAwardDbContext>(scope);

    app.UseStaticFiles(new StaticFileOptions
    {
        ServeUnknownFileTypes = true,
        OnPrepareResponse = ctx =>
        {
            if (ctx.Context.Request.Headers.ContainsKey("Origin"))
            {
                var origin = ctx.Context.Request.Headers["Origin"].ToString();

                var allowedOrigins = new[]
                {
                    builder.Configuration.GetValue<string>("WebSite_Front_URL"),
                    builder.Configuration.GetValue<string>("Dashboard_Front_URL"),
                    builder.Configuration.GetValue<string>("Subscriber_Front_URL")
                };

                if (allowedOrigins.Contains(origin))
                {
                    ctx.Context.Response.Headers.Append("Access-Control-Allow-Origin", origin);
                }
                else
                {
                    ResponseMessage = $"Origin not allowed: {origin}";

                    string xx = null;
                    string yy = xx.ToLower();
                }
            }
            else
            {
                // Handle the case where Origin is not sent
                Console.WriteLine("Origin header not present in the request.");
            }
        }
    });
    
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();
    app.UseRouting();
    //app.UseMiddleware<AuthenticationMiddleware>();
    app.UseMiddleware<ExceptionMiddleware>();
    app.UseAuthentication();
    app.UseAuthorization();


    app.UseStaticFiles();


    app.UseCors("Open");

    //hangfire

    //app.UseHangfireDashboard();

    //RecurringJob.AddOrUpdate<IBackGroundJobService>("Change Agenda State", service => service.ChangeAgendaStateAsync(), Cron.Minutely);

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });

    app.Run();
    
}
catch (Exception ex)
{
    var builder = WebApplication.CreateBuilder(args);

    var app = builder.Build();

    if (!string.IsNullOrEmpty(ResponseMessage))
    {
        app.Use(async (Runcontext, next) =>
        {
            Runcontext.Response.Clear();
            Runcontext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;

            await Runcontext.Response.WriteAsync(JsonConvert.SerializeObject(new { ErrorMessage = ResponseMessage }));

            await next.Invoke();
        });
    }
    else
    {
        app.Use(async (Runcontext, next) =>
        {
            Runcontext.Response.Clear();
            Runcontext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;

            if (ex.InnerException is not null ? !string.IsNullOrEmpty(ex.InnerException.Message) : false)
                await Runcontext.Response.WriteAsync(JsonConvert.SerializeObject(new { ErrorMessage = ex.Message, ErrorInnerMessage = ex.InnerException.Message }));
            else
                await Runcontext.Response.WriteAsync(JsonConvert.SerializeObject(new { ErrorMessage = ex.Message }));

            await next.Invoke();
        });
    }

    app.Run();
}   

static void ApplyMigration<TDbContext>(IServiceScope scope)
    where TDbContext : DbContext
{
    using TDbContext context = scope.ServiceProvider
        .GetRequiredService<TDbContext>();

    context.Database.Migrate();
}