using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.DeleteGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.UpdateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.ConfirmAttendanceGroup;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetAllGroupInvitees;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupInviteeById;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.DeletePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.UpdatePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ConfirmAttendancePersonal;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetAllPersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalInviteeById;

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

        [HttpPost("CreateGroupInvitee",Name = "AddGroupInvitee")]
        public async Task<ActionResult<Guid>> AddGroupInvitee([FromBody] CreateGroupInviteeCommand createGroupInviteeCommand)
        {
            var response = await _mediator.Send(createGroupInviteeCommand);
            return Ok(new { data = response });
        }

        [HttpPut("UpdateGroupInvitee", Name = "UpdateGroupInvitee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateGroupInvitee([FromBody] UpdateGroupInviteeCommand updateGroupInviteeCommand)
        {

            await _mediator.Send(updateGroupInviteeCommand);
            return Ok(new {data = Response });
        }

        [HttpDelete("DeleteGroupInvitee",Name = "DeleteGroupInvitee")]
        public async Task<ActionResult> DeleteGroupInvitee(Guid id)
        {
            DeleteGroupInviteeCommand deleteGroupInviteeCommand = new DeleteGroupInviteeCommand()
            {
                Id = id
            };
            await _mediator.Send(deleteGroupInviteeCommand);
            return Ok(Response);
        }

        [HttpGet("GetGroupInviteeById/{id}", Name = "GetGroupInviteeById")]
        public async Task<ActionResult<GetGroupInviteeByIdQuery>> GetById(Guid id)
        {
            GroupInviteeVM? Group = await _mediator
                .Send(new GetGroupInviteeByIdQuery
                {
                    Id = id
                });
            return Ok(new { data = Group });
        }

        [HttpGet("GetAllGroupInvitee",Name = "GetAllGroupInvitee")]
        public async Task<ActionResult> GetAllGroupInvitee(int page , int perPage)
        {
            if (perPage == 0)
                perPage = 10;

            var dto = await _mediator.Send(new GetAllGroupInviteeQuery());
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
