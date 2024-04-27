using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using NPOI.OpenXmlFormats.Spreadsheet;
using SharijhaAward.Application.Features.UserFeatures.Commands.ChangePassword;
using SharijhaAward.Application.Features.UserFeatures.Commands.CreateUser;
using SharijhaAward.Application.Features.UserFeatures.Commands.DeleteUser;
using SharijhaAward.Application.Features.UserFeatures.Commands.UpdateUser;
using SharijhaAward.Application.Features.UserFeatures.Queries.GetAllUsers;
using SharijhaAward.Application.Features.UserFeatures.Queries.GetUserById;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersForAdminDashboardController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public UsersForAdminDashboardController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }

        [HttpPost("ChangePasswordForAdmin", Name = "ChangePasswordForAdmin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ChangePasswordForAdmin([FromBody] ChangePasswordCommand ChangePasswordCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            ChangePasswordCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(ChangePasswordCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("CreateUserForAdmin", Name = "CreateUserForAdmin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateUserForAdmin([FromBody] CreateUserCommand CreateUserCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateUserCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(CreateUserCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("{Id}", Name = "DeleteUserForAdmin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteUserForAdmin(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteUserCommand()
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

        //[HttpPut(Name= "UpdateUserForAdmin")]
        //public async Task<IActionResult> UpdateUserForAdmin(UpdateUserCommand command)
        //{
        //    var language = HttpContext.Request.Headers["lang"];

        //    command.lang = language!;

        //    var response = await _Mediator.Send(command);
        //    return response.statusCode switch
        //    {
        //        404 => NotFound(response),
        //        200 => Ok(response),
        //        _ => BadRequest(response)
        //    };
        //}
            //[HttpPut(Name = "UpdateUserForAdmin")]
            //public async Task<IActionResult> UpdateUserForAdmin(UpdateUserCommand UpdateUserCommand)
            //{
            //    StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            //    UpdateUserCommand.lang = !string.IsNullOrEmpty(HeaderValue)
            //        ? HeaderValue
            //        : "en";

            //    BaseResponse<object>? Response = await _Mediator.Send(UpdateUserCommand);

            //    return Response.statusCode switch
            //    {
            //        404 => NotFound(Response),
            //        200 => Ok(Response),
            //        _ => BadRequest(Response)
            //    };

            //}

        [HttpGet(Name = "GetAllUsersForAdmin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllUsersForAdmin(int Page = 1, int PerPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllUsersListVM>> Response = await _Mediator.Send(new GetAllUsersQuery()
            {
                lang = HeaderValue!,
                page = Page,
                pageSize = PerPage
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("{Id}", Name = "GetUserByIdFormAdmin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetUserByIdFormAdmin(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetUserByIdDto> Response = await _Mediator.Send(new GetUserByIdQuery()
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
    }
}
