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
using SharijhaAward.Application.Features.User.Queries.GetAllUsers;
using SharijhaAward.Application.Features.User.Queries.GetUserById;
using SharijhaAward.Application.Responses;


 
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
        [HttpPut(Name = "UpdateUser")]

        public async Task<ActionResult> UpdateUser([FromBody] UpdateUserCommand updateUserCommand)
        {
            await _mediator.Send(updateUserCommand);
            return Ok(new {message = Response });
        }

        [HttpDelete(Name = "DeleteUser")]

        public async Task<ActionResult> DeleteUser([FromBody] DeleteUserCommand deleteUser)
        {
            await _mediator.Send(deleteUser);
            return Ok(new {message = Response});
        }

        [HttpGet("{id}", Name = "GetUserById")]

        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetUserById(Guid id)
        {
           var user =  await _mediator.Send(new GetUserByIdQuery { Id = id});
            return Ok(
                new 
                { 
                    data = user, 
                    status = true 
                });

        }
        [HttpGet(Name = "GetAllUsers")]

        public async Task<ActionResult> GetAllUsers(int page , int perPage)
        {
            var dto = await _mediator.Send(new GetAllUsersQuery());
            // Pagenation
            if (perPage == 0)
                perPage = 10;
            else if (perPage == -1)
                return Ok(
                new
                {
                    data = dto,
                    status = true,
                });

            var totalCount = dto.Count;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / perPage);
            var dataPerPage = dto
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            return Ok(
                new
                {
                    data = dataPerPage,
                    status = true,
                    pagination =
                    new
                    {
                        current_page = page,
                        last_page = totalPage,
                        total_row = totalCount,
                        per_page = perPage
                    }
                });
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
    }
}
