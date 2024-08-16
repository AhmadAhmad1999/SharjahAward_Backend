using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.LoggerModel;
using System.Diagnostics;

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
        public override async void OnActionExecuting(ActionExecutingContext filterContext)
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

            //try
            //{
            //    List<object> Controller_Function_Name = filterContext.RouteData.Values.Values.ToList();

            //    if (Controller_Function_Name[1].ToString() != "Authentication" &&
            //        (Controller_Function_Name[0].ToString() != "Login" ||
            //        Controller_Function_Name[0].ToString() != "SignUp"))
            //    {
            //        if (!string.IsNullOrEmpty(token) && token.ToLower() != "bearer null" &&
            //            token.ToLower() != "bearer" && token.ToLower() != "bearer ")
            //        {
            //            IAsyncRepository<UserToken>? _UserTokenRepository = _ServiceProvider.GetService<IAsyncRepository<UserToken>>();

            //            UserToken? CheckUserId = await _UserTokenRepository!
            //                .FirstOrDefaultAsync(x => x.Id == int.Parse(_JwtProvider.GetUserIdFromToken(token)) &&
            //                    x.Token == token);

            //            if (CheckUserId is not null)
            //                UserId = int.Parse(_JwtProvider.GetUserIdFromToken(token));

            //            else
            //            {
            //                string StartException1 = null;
            //                StartException1.ToLower();
            //            }
            //        }
            //        else
            //        {
            //            string StartException1 = null;
            //            StartException1.ToLower();
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    throw new UnauthorizedAccessException();
            //}

            if (!string.IsNullOrEmpty(token) && token.ToLower() != "bearer null" &&
                token.ToLower() != "bearer" && token.ToLower() != "bearer ")
                UserId = int.Parse(_JwtProvider.GetUserIdFromToken(token));
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            IAsyncRepository<LogUserAction> _LogUserActionRepository = _ServiceProvider.GetService<IAsyncRepository<LogUserAction>>();

            // Check If There Any Exception In API Response..
            Exception Exceptions = filterContext.Exception;

            string httpMethod = filterContext.HttpContext.Request.Method;

            if (Exceptions != null)
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

                        _LogUserActionRepository.AddAsync(NewLog);
                    }
                }
            }
        }
    }
}
