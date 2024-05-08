using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using OpenQA.Selenium.DevTools.V120.Browser;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.Authentication;
using SharijhaAward.Application.Features.Authentication.CheckConfirmationCodeForForgettonPassword;
using SharijhaAward.Application.Features.Authentication.CheckConfirmationCodeForSignUp;
using SharijhaAward.Application.Features.Authentication.ForgetPassword;
using SharijhaAward.Application.Features.Authentication.Login;
using SharijhaAward.Application.Features.Authentication.ShowAsSubscriber;
using SharijhaAward.Application.Features.Authentication.SignUp;
using SharijhaAward.Application.Features.Authentication.SingUpFromAdminDashboard;
using SharijhaAward.Application.Features.Authentication.VerifyAccount;
using SharijhaAward.Application.Features.Settings.Commands.CheckForConfirmationCode;
using SharijhaAward.Application.Features.Settings.Commands.ResetPassword;
using SharijhaAward.Application.Features.Settings.Commands.SendConfirmationCodeForResetPassword;
using SharijhaAward.Application.Responses;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public AuthenticationController(IMediator mediator)
        {
            _Mediator = mediator;
        }
        [HttpGet("APIForTestPublishOnly")]
        public IActionResult APIForTestPublishOnly()
        {
            return Ok("Connected TO BackEnd Successfuly");
        }
        [HttpPost("Login", Name = "Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<string>> Login([FromBody] LoginCommand user)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            var response = await _Mediator.Send(
                new LoginCommand()
                { 
                    Email = user.Email,
                    Password = user.Password,
                    lang = HeaderValue,
                    intoAdminDashboard = user.intoAdminDashboard
                });

            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            if (response.user == null)
            {
                return StatusCode(400,
                    new
                    {
                        message = response.message
                    });
            }
            else
                return Ok(
                    new
                    {
                        data = response.user,
                        key = response.token,
                        permission = response.permissions,
                        message = response.message
                    }
                );
        }
        [HttpPost("SignUp", Name = "SignUp")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<string>> SignUp([FromBody] SignUpCommand user)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            var response = await _Mediator.Send(new SignUpCommand()
            {
                Email = user.Email,
                Password = user.Password,
                RoleName = user.RoleName,
                Gender = user.Gender,
                PhoneNumber = user.PhoneNumber,
                lang = HeaderValue
            });

            if (!response.isSucceed)
            {
                return StatusCode(400,
                    new
                    {
                        message = response.message
                    });
            }
            else
                return Ok(
                    new
                    {
                        data = response.user,
                        key = response.token,
                        permission = response.permissions,
                        message = response.message

                    });
        }
        [HttpPost("SingUpFromAdminDashboard", Name = "SingUpFromAdminDashboard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<string>> SingUpFromAdminDashboard([FromBody] SingUpFromAdminDashboardCommand user)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            var response = await _Mediator.Send(new SingUpFromAdminDashboardCommand()
            {
                Email = user.Email,
                Password = user.Password,
                RoleName = user.RoleName,
                Gender = user.Gender,
                PhoneNumber = user.PhoneNumber,
                lang = HeaderValue
            });

            if (!response.isSucceed)
            {
                return StatusCode(400,
                    new
                    {
                        message = response.message
                    });
            }
            else
                return Ok(
                    new
                    {
                        data = response.user,
                        key = response.token,
                        permission = response.permissions,
                        message = response.message

                    });
        }
        [HttpPost("CheckConfirmationCodeForSignUp")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> CheckConfirmationCodeForSignUp(CheckConfirmationCodeForSignUpCommand CheckConfirmationCodeForSignUpCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            CheckConfirmationCodeForSignUpCommand.lang = HeaderValue!;

            BaseResponse<object>? Response = await _Mediator.Send(CheckConfirmationCodeForSignUpCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("CheckConfirmationCodeForForgettonPassword")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> CheckConfirmationCodeForForgettonPassword
            (CheckConfirmationCodeForForgettonPasswordCommand CheckConfirmationCodeForForgettonPasswordCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            CheckConfirmationCodeForForgettonPasswordCommand.lang = HeaderValue!;

            BaseResponse<object>? Response = await _Mediator.Send(CheckConfirmationCodeForForgettonPasswordCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("ForgetPassword")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ForgetPassword(string Email)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<int>? Response = await _Mediator.Send(new ForgetPasswordCommand()
            {
                lang = HeaderValue!,
                Email = Email
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpGet("ShowAsSubscriber/{UserId}", Name = "ShowAsSubscriber")]
        public async Task<IActionResult> ShowAsSubscriber(int UserId)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;
            
            if(token.IsNullOrEmpty())
            {
                return Unauthorized();
            }

            var response = await _Mediator.Send(new ShowAsSubscriberQuery()
            {
                token = token!,
                lang = language!,
                UserId = UserId,
            });

            return response.isSucceed switch
            {
                true => Ok(response),
                false => NotFound(response)
            };
        }
        [HttpPut("VerifyAccount")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> VerifyAccount([FromBody] VerifyAccountCommand VerifyAccountCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            VerifyAccountCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(VerifyAccountCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
