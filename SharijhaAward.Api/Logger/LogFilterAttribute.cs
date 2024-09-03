using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.LoggerModel;
using System.Diagnostics;
using System.Reflection;

namespace SharijhaAward.Api.Logger
{
    public class LogFilterAttribute : ActionFilterAttribute
    {
        static public int? UserId { get; set; }
        private readonly IServiceCollection _ServiceCollection;
        private readonly ILogger<LogFilterAttribute> _Logger;
        private IServiceProvider _ServiceProvider;
        private IJwtProvider _JwtProvider;
        public static List<ActionParamaters> MyParametersList { get; set; } = new List<ActionParamaters>();
        public class ActionParamaters
        {
            public Guid GuidId { get; set; }
            public IDictionary<string, object> Parameters { get; set; }
        }

        public LogFilterAttribute(IServiceProvider ServiceProvider,
            ILogger<LogFilterAttribute> logger,
            IJwtProvider JwtProvider)
        {
            _ServiceProvider = ServiceProvider;
            _Logger = logger;
            _JwtProvider = JwtProvider;
        }
        public override async Task OnActionExecutionAsync(ActionExecutingContext filterContext, ActionExecutionDelegate next)
        {
            Guid GuidId = Guid.NewGuid();
            Trace.CorrelationManager.ActivityId = GuidId;
            filterContext.HttpContext.TraceIdentifier = GuidId.ToString();
            IDictionary<string, object> Parameters = filterContext.ActionArguments;
            MyParametersList.Add(new ActionParamaters
            {
                GuidId = GuidId,
                Parameters = Parameters
            });

            string token = filterContext.HttpContext.Request.Headers["Authorization"].ToString();

            try
            {
                List<object> Controller_Function_Name = filterContext.RouteData.Values.Values.ToList();

                if (Controller_Function_Name[0].ToString() != "Login" &&
                    Controller_Function_Name[0].ToString() != "SignUp" &&
                    Controller_Function_Name[0].ToString() != "ApplySeeder" &&
                    Controller_Function_Name[0].ToString() != "CheckConfirmationCodeForSignUp" &&
                    Controller_Function_Name[0].ToString() != "CheckConfirmationCodeForForgettonPassword" &&
                    Controller_Function_Name[0].ToString() != "SignUpFromAdminDashboard" &&
                    Controller_Function_Name[0].ToString() != "MigrateAndSeedDatabase" &&
                    (Controller_Function_Name[1].ToString() != "Website"))
                {
                    if (!string.IsNullOrEmpty(token) && token.ToLower() != "bearer null" &&
                        token.ToLower() != "bearer" && token.ToLower() != "bearer ")
                    {
                        IAsyncRepository<UserToken>? _UserTokenRepository = _ServiceProvider.GetService<IAsyncRepository<UserToken>>();

                        token = token.Replace("Bearer ", string.Empty);
                        token = token.Replace("bearer ", string.Empty);

                        UserToken? CheckUserId = await _UserTokenRepository!
                            .FirstOrDefaultAsync(x => x.UserId == int.Parse(_JwtProvider.GetUserIdFromToken(token)) &&
                                x.Token == token);

                        if (CheckUserId is not null)
                            UserId = int.Parse(_JwtProvider.GetUserIdFromToken(token));

                        else
                        {
                            throw new UnauthorizedAccessException();
                        }
                    }
                    else
                    {
                        throw new UnauthorizedAccessException();
                    }
                }
            }
            catch (Exception)
            {
                throw new UnauthorizedAccessException();
            }

            if (!string.IsNullOrEmpty(token) && token.ToLower() != "bearer null" &&
                token.ToLower() != "bearer" && token.ToLower() != "bearer ")
                UserId = int.Parse(_JwtProvider.GetUserIdFromToken(token));

            ActionExecutedContext APIResponse = await next();

            OnActionExecuted(APIResponse);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            IAsyncRepository<LogUserAction> _LogUserActionRepository = _ServiceProvider.GetService<IAsyncRepository<LogUserAction>>();

            // Check If There Any Exception In API Response..
            Exception Exceptions = filterContext.Exception;

            string httpMethod = filterContext.HttpContext.Request.Method;

            if (Exceptions is not null)
            {
                try
                {
                    LogUserAction NewLog = new LogUserAction();

                    // 1. Date..
                    NewLog.Date = DateTime.UtcNow;

                    // 2. User Id..
                    if (UserId != null)
                        NewLog.UserId = UserId.Value;

                    // 3. Controller Name..
                    List<object> Controller_Function_Name = filterContext.RouteData.Values.Values.ToList();
                    NewLog.ControllerName = Controller_Function_Name[1].ToString();

                    // 4. Function Name..
                    NewLog.FunctionName = Controller_Function_Name[0].ToString();

                    // Http Method..
                    NewLog.HttpMethod = httpMethod;

                    // 5. Body Parameters..
                    IDictionary<string, object> Parameters = MyParametersList.Where(x =>
                        x.GuidId.ToString() == filterContext.HttpContext.TraceIdentifier).Select(x => x.Parameters).FirstOrDefault();
                    NewLog.BodyParameters = Newtonsoft.Json.JsonConvert.SerializeObject(Parameters);

                    // 6. Header Paramaters..
                    NewLog.HeaderParameters = Newtonsoft.Json.JsonConvert.SerializeObject(filterContext.HttpContext.Request.Headers);

                    // 7. Response Status..
                    NewLog.ResponseStatus = "Failed";

                    // 8. Result...
                    NewLog.Result = Exceptions.Message;

                    // 9. Activity Id...
                    NewLog.ActivityId = Trace.CorrelationManager.ActivityId;

                    _Logger.LogError(Exceptions.Message);
                    _LogUserActionRepository.AddAsync(NewLog);
                    Thread.Sleep(200);
                }
                catch (Exception err)
                {
                    _Logger.LogError(err.Message);
                }
            }
            else
            {
                if (!string.Equals(httpMethod, "GET", StringComparison.OrdinalIgnoreCase))
                {
                    IActionResult? ActionResult = filterContext.Result;
                    if (ActionResult is OkObjectResult json)
                    {
                        dynamic DynamicObject = json.Value;

                        LogUserAction NewLog = new LogUserAction();

                        // 1. Date..
                        NewLog.Date = DateTime.UtcNow;

                        // 2. User Id..
                        if (UserId != null)
                            NewLog.UserId = UserId.Value;

                        // 3. Controller Name..
                        List<object> Controller_Function_Name = filterContext.RouteData.Values.Values.ToList();
                        NewLog.ControllerName = Controller_Function_Name[1].ToString();

                        // 4. Function Name..
                        NewLog.FunctionName = Controller_Function_Name[0].ToString();

                        // Http Method..
                        NewLog.HttpMethod = httpMethod;

                        // 5. Body Parameters..
                        IDictionary<string, object> Parameters = MyParametersList.Where(x =>
                            x.GuidId.ToString() == filterContext.HttpContext.TraceIdentifier).Select(x => x.Parameters).FirstOrDefault();

                        NewLog.BodyParameters = Newtonsoft.Json.JsonConvert.SerializeObject(Parameters);

                        // 6. Header Paramaters..
                        NewLog.HeaderParameters = Newtonsoft.Json.JsonConvert.SerializeObject(filterContext.HttpContext.Request.Headers);

                        // 7. Response Status..
                        NewLog.ResponseStatus = "Succeed";

                        // 8. Result...
                        NewLog.Result = Newtonsoft.Json.JsonConvert.SerializeObject(DynamicObject);

                        // 9. Activity Id...
                        NewLog.ActivityId = Trace.CorrelationManager.ActivityId;

                        // 10. Record Id...
                        var CheckIfIdInRequest = Parameters.FirstOrDefault(x => x.Key.ToLower() == "id");

                        if (Controller_Function_Name.Count() == 3 && (httpMethod.ToLower() == "delete" || httpMethod.ToLower() == "put"))
                        {
                            NewLog.RecordId = int.Parse(Controller_Function_Name[2].ToString()!);
                        }
                        else if (CheckIfIdInRequest.Value != null)
                        {
                            NewLog.RecordId = int.Parse(CheckIfIdInRequest.Value.ToString()!);
                        }
                        else if (CheckIfIdInRequest.Value == null && Parameters.FirstOrDefault().Value != null)
                        {
                            PropertyInfo? CheckIdInCommand = Parameters.FirstOrDefault().Value.GetType().GetProperty("Id");

                            if (CheckIdInCommand != null)
                            {
                                NewLog.RecordId = int.Parse(Parameters.FirstOrDefault().Value.GetType()
                                    .GetProperty("Id")!.GetValue(Parameters.FirstOrDefault().Value)!.ToString()!);
                            }
                        }

                        _LogUserActionRepository.AddAsync(NewLog);
                        Thread.Sleep(200);
                    }
                }
            }
        }
    }
}
