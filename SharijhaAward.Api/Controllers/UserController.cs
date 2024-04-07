using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Settings.Commands.SendConfirmationCodeForResetPassword;
using SharijhaAward.Application.Features.User.Commands.DeleteUser;
using SharijhaAward.Application.Features.User.Commands.UpdateUser;
using SharijhaAward.Application.Features.User.Queries.AsignRoleToUser;
using SharijhaAward.Application.Features.User.Queries.ChangePassword;
using SharijhaAward.Application.Features.User.Queries.GetAllSubscribers;
using SharijhaAward.Application.Features.User.Queries.GetAllUsers;
using SharijhaAward.Application.Features.User.Queries.GetUserById;
using SharijhaAward.Application.Responses;
using System.Reflection.Metadata.Ecma335;



namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPut("{Id}",Name = "UpdateUser")]

        public async Task<ActionResult> UpdateUser(Guid Id ,[FromBody] UpdateUserCommand updateUserCommand)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            updateUserCommand.lang = language!;
            updateUserCommand.Id = Id;

            var response = await _mediator.Send(updateUserCommand);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpDelete("{Id}",Name = "DeleteUser")]

        public async Task<ActionResult> DeleteUser(Guid Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteUserCommand()
            {
                lang = language!,
                Id = Id
            });
            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("{id}", Name = "GetUserById")]

        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetUserById(Guid? id)
        {
            var Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            var response =  await _mediator.Send(new GetUserByIdQuery
            {
                Id = id,
                token =Token!
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };

        }
        [HttpGet(Name = "GetAllUsers")]

        public async Task<ActionResult> GetAllUsers(int page , int perPage)
        {
            var response = await _mediator.Send(new GetAllUsersQuery()
            {
                page = page,
                pageSize = perPage
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };

        }
        [HttpPost("AsignRole",Name = "AsignRole")]

        public async Task<ActionResult> AsignRole([FromBody] AsignRoleToUserQuery query)
        {
            await _mediator.Send(new AsignRoleToUserQuery()
            { 
                roleId = query.roleId ,
                userId = query.userId
            });
            return Ok(
                new
                {
                    message = "AsignRole successfully.",
                    status = true
                });

        }
        [HttpPost("ChangePassword", Name = "ChangePassword")]
        public async Task<ActionResult> ChangePassword([FromBody] ChangePasswordQuery query)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            query.Token = Token!;

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            query.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue!
                : "en";

            BaseResponse<object>? Response = await _mediator.Send(query);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpGet("GetAllSubscribers", Name= "GetAllSubscribers")]
        public async Task<IActionResult> GetAllSubscribers(int page = 1 , int perPage = 10)
        {
            var response = await _mediator.Send(new GetAllSubscribersQuery()
            {
                page = page,
                pageSize = perPage
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };

        }
    }
}
