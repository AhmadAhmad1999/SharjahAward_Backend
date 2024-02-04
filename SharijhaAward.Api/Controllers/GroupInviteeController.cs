using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.DeleteGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.UpdateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.ConfirmAttendanceGroup;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetAllGroupInvitees;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupInviteeById;


namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupInviteeController : Controller
    {
        private readonly IMediator _mediator;

        public GroupInviteeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "AddGroupInvitee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<Guid>> AddGroupInvitee([FromBody] CreateGroupInviteeCommand createGroupInviteeCommand)
        {
            var headerValue = HttpContext.Request.Headers["lang"];
            if (!string.IsNullOrWhiteSpace(headerValue))
                createGroupInviteeCommand.lang = headerValue;

            var response = await _mediator.Send(createGroupInviteeCommand);
            return Ok(new { data = response });
        }

        [HttpPut(Name = "UpdateGroupInvitee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateGroupInvitee([FromBody] UpdateGroupInviteeCommand updateGroupInviteeCommand)
        {

            await _mediator.Send(updateGroupInviteeCommand);
            return Ok(new { data = Response });
        }


        [HttpDelete(Name = "DeleteGroupInvitee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteGroupInvitee(Guid id)
        {
            DeleteGroupInviteeCommand deleteGroupInviteeCommand = new DeleteGroupInviteeCommand()
            {
                Id = id
            };
            await _mediator.Send(deleteGroupInviteeCommand);
            return Ok(Response);
        }


        [HttpGet("{Id}", Name = "GetGroupInviteeById")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<GetGroupInviteeByIdQuery>> GetById(Guid id)
        {
            GroupInviteeVM? Group = await _mediator
                .Send(new GetGroupInviteeByIdQuery
                {
                    Id = id
                });
            return Ok(new { data = Group });
        }

        [HttpGet(Name = "GetAllGroupInvitee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllGroupInvitee(int page , int perPage)
        {
            var dto = await _mediator.Send(new GetAllGroupInviteeQuery());

            if (perPage == 0)
                perPage = 10;
            else if (perPage == -1)
                return Ok(
                new
                {
                    data = dto,
                    message = "Retrieved successfully.",
                    status = true,
                });

          
            var totalCount = dto.Count;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / perPage);
            var dataPerPage = dto
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            return Json(
                new
                {
                    data = dataPerPage,
                    message = "Retrieved successfully.",
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

        [HttpPost("ConfirmAttendanceGroup", Name = "ConfirmAttendanceGroup")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> ConfirmAttendanceGroup([FromBody] ConfirmAttendanceGroupQuery query)
        {
            var respone = await _mediator.Send(new ConfirmAttendanceGroupQuery()
            {
                Id = query.Id,
                NumberOfAttendees=query.NumberOfAttendees
            });

            return Ok(respone);
        }
    }
}
