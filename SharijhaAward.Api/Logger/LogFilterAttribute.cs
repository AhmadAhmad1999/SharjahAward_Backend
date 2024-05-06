using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.AppVersioningModel;
using SharijhaAward.Domain.Entities.LoggerModel;
using System.Diagnostics;
using System.Dynamic;
using System.IdentityModel.Tokens.Jwt;

namespace SharijhaAward.Api.Logger
{
    public class LogFilterAttribute : ActionFilterAttribute
    {
        static public int? UserId { get; set; }
        private readonly IServiceCollection _Services;
        private readonly ServiceProvider _ServiceProvider;
        private readonly ILogger<LogFilterAttribute> _Logger;
        private readonly IAsyncRepository<LogUserAction> _LogUserActionRepository;
        public static List<ActionParamaters> MyParametersList { get; set; } = new List<ActionParamaters>();
        public class ActionParamaters
        {
            public Guid GuidId { get; set; }
            public IDictionary<string, object> Parameters { get; set; }
        }
        //public LogFilterAttribute(IServiceCollection Services, ILogger<LogFilterAttribute> Logger
        //    /*IAsyncRepository<LogUserAction> LogUserActionRepository*/)
        //{
        //    _Services = Services;
        //    _ServiceProvider = _Services.BuildServiceProvider();
        //    _Logger = Logger;
        //}
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Guid GuidId = Guid.Parse(filterContext.HttpContext.TraceIdentifier);
            Trace.CorrelationManager.ActivityId = GuidId;
            IDictionary<string, object> Parameters = filterContext.ActionArguments;
            MyParametersList.Add(new ActionParamaters
            {
                GuidId = GuidId,
                Parameters = Parameters
            });
            string token = filterContext.HttpContext.Request.Headers["Authorization"].ToString();

            if (!string.IsNullOrEmpty(token) && token.ToLower() != "bearer null")
                UserId = Int32.Parse(new JwtSecurityTokenHandler().ReadJwtToken(token.Split(" ")[1]).Claims.ToList()[0].Value);
        }
        public override void OnActionExecuted(ActionExecutedContext FilterContext)
        {
            // Check If There Any Exception In API Response..
            Exception Exceptions = FilterContext.Exception;

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
                    List<object> Controller_Function_Name = FilterContext.RouteData.Values.Values.ToList();
                    NewLog.ControllerName = Controller_Function_Name[1].ToString();

                    // 4. Function Name..
                    NewLog.FunctionName = Controller_Function_Name[0].ToString();

                    // 5. Body Parameters..
                    IDictionary<string, object>? Parameters = MyParametersList.Where(x =>
                        x.GuidId == Guid.Parse(FilterContext.HttpContext.TraceIdentifier)).Select(x => x.Parameters).FirstOrDefault();
                    NewLog.BodyParameters = Newtonsoft.Json.JsonConvert.SerializeObject(Parameters);

                    // 6. Header Paramaters..
                    NewLog.HeaderParameters = Newtonsoft.Json.JsonConvert.SerializeObject(FilterContext.HttpContext.Request.Headers);

                    // 7. Response Status..
                    NewLog.ResponseStatus = "Failed";

                    // 8. Result...
                    NewLog.Result = Exceptions.Message;

                    if (Exceptions != null)
                    {
                        
                    }
                    else
                    {
                        IActionResult? ActionResult = FilterContext.Result;
                        if (ActionResult is OkObjectResult APIResult)
                        {
                            dynamic? DynamicObject = new ExpandoObject();
                            DynamicObject = APIResult.Value;
                            if (DynamicObject != null ? 
                                !string.IsNullOrEmpty(DynamicObject.Errors)
                                : false)
                            {
                                // 7. Response Status..
                                NewLog.ResponseStatus = "Failed";

                                // 8. Result...
                                NewLog.Result = DynamicObject.Errors;
                            }
                            else if (DynamicObject.Code == 0)
                            {
                                // 7. Response Status..
                                NewLog.ResponseStatus = "Success";

                                // 8. Result...
                                NewLog.Result = Newtonsoft.Json.JsonConvert.SerializeObject(DynamicObject);
                            }
                        }
                    }
                    //UnitOfWork.LogUsersActionsRepository.AddAsync(NewLog);
                    //UnitOfWork.SaveChangesAsync();
                }
                catch (Exception err)
                {
                    _Logger.LogError(err.Message);
                }
            }
        }
    }
}
