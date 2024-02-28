using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.User.Commands.DeleteUser;
using SharijhaAward.Application.Features.User.Commands.UpdateUser;
using SharijhaAward.Application.Features.User.Queries.AsignRoleToUser;
using SharijhaAward.Application.Features.User.Queries.ChangePassword;
using SharijhaAward.Application.Features.User.Queries.GetAllUsers;
using SharijhaAward.Application.Features.User.Queries.GetUserById;

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
        public async Task<ActionResult> ChangePassword([FromBody]ChangePasswordQuery query)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            var token = HttpContext.Request.Headers.Authorization;

            query.Token = token!;
            query.lang = headerValue!;
            var response = await _mediator.Send(query);

            if (response.statusCode == 404)
            {
                return NotFound(new { response });
            }
            else if (response.statusCode == 400)
            {
                return BadRequest(new { response });
            }
            else
                return Ok(
                    new 
                    {
                        response.message,
                        response.success,
                        response.statusCode,
                    });
        }
    }
}
