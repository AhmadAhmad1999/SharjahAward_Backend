using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using OpenQA.Selenium.DevTools.V120.Browser;
using SharijhaAward.Application.Features.Authentication;
using SharijhaAward.Application.Features.Authentication.CheckConfirmationCodeForSignUp;
using SharijhaAward.Application.Features.Authentication.Login;
using SharijhaAward.Application.Features.Authentication.SignUp;
using SharijhaAward.Application.Features.Settings.Commands.CheckForConfirmationCode;
using SharijhaAward.Application.Features.Settings.Commands.SendConfirmationCodeForResetPassword;
using SharijhaAward.Application.Responses;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SharijhaAward.Api.Controllers
{
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
        //
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
    }
}
