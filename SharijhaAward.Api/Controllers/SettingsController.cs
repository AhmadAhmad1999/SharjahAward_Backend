using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.Settings.Commands.ChangeUserAccountLanguage;
using SharijhaAward.Application.Features.Settings.Commands.CheckForConfirmationCode;
using SharijhaAward.Application.Features.Settings.Commands.DeleteProfile;
using SharijhaAward.Application.Features.Settings.Commands.EditPrivacyPolicy;
using SharijhaAward.Application.Features.Settings.Commands.EditProfile;
using SharijhaAward.Application.Features.Settings.Commands.EditTermsOfUse;
using SharijhaAward.Application.Features.Settings.Commands.ResetPassword;
using SharijhaAward.Application.Features.Settings.Commands.SendConfirmationCodeForResetPassword;
using SharijhaAward.Application.Features.Settings.Queries.GetPrivacyPolicy;
using SharijhaAward.Application.Features.Settings.Queries.GetProfileById;
using SharijhaAward.Application.Features.Settings.Queries.GetTermsOfUse;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly IMediator _Mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public SettingsController(IMediator Mediator,
            IWebHostEnvironment WebHostEnvironment)
        {
            _Mediator = Mediator;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpGet("GetProfileById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetProfileById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetProfileByIdDto> Response = await _Mediator.Send(new GetProfileByIdQuery()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("SendConfirmationCodeForResetPassword")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> SendConfirmationCodeForResetPassword()
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            BaseResponse<object>? Response = await _Mediator.Send(new SendConfirmationCodeForResetPasswordCommand()
            {
                token = Token,
                lang = !string.IsNullOrEmpty(HeaderValue)
                    ? HeaderValue
                    : "en"
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("EditProfile")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> EditProfile([FromForm] EditProfileCommand EditProfileCommand)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            EditProfileCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            EditProfileCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "\\ProfilePics\\";
            EditProfileCommand.Token = Token;

            BaseResponse<object>? Response = await _Mediator.Send(EditProfileCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("ResetPassword")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ResetPassword(string NewPassword)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new ResetPasswordCommand()
            {
                lang = HeaderValue!,
                NewPassword = NewPassword,
                Token = Token!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("CheckForConfirmationCode")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> CheckForConfirmationCode(int ConfirmationCode)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new CheckForConfirmationCodeCommand()
            {
                ConfirmationCode = ConfirmationCode,
                lang = HeaderValue!,
                Token = Token!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteProfile")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteProfile(string Email)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteProfileCommand()
            {
                lang = HeaderValue!,
                Email = Email,
                Token = Token
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("EditPrivacyPolicy")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> EditPrivacyPolicy(EditPrivacyPolicyCommand EditPrivacyPolicyCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            EditPrivacyPolicyCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(EditPrivacyPolicyCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetPrivacyPolicy")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetPrivacyPolicy(string Slug)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetPrivacyPolicyDto> Response = await _Mediator.Send(new GetPrivacyPolicyQuery()
            {
                Slug = Slug,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("EditTermsOfUse")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> EditTermsOfUse(EditTermsOfUseCommand EditTermsOfUseCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            EditTermsOfUseCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(EditTermsOfUseCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetTermsOfUse")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetTermsOfUse(string Slug)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetTermsOfUseDto> Response = await _Mediator.Send(new GetTermsOfUseQuery()
            {
                Slug = Slug,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("ChangeUserAccountLanguage")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ChangeUserAccountLanguage(string NewLanguage)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            BaseResponse<object>? Response = await _Mediator.Send(new ChangeUserAccountLanguageCommand()
            {
                lang = !string.IsNullOrEmpty(HeaderValue)
                    ? HeaderValue
                    : "en",
                Token = Token,
                NewLanguage = NewLanguage
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
