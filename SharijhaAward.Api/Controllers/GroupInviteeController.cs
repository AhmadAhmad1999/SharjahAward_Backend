using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.DeleteGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.UpdateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetAllGroupInvitees;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupInviteeById;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.DeletePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.UpdatePersonalInvitee;
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
            return Ok(response);
        }

        [HttpPut("UpdateGroupInvitee", Name = "UpdateGroupInvitee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateGroupInvitee([FromBody] UpdateGroupInviteeCommand updateGroupInviteeCommand)
        {

            await _mediator.Send(updateGroupInviteeCommand);
            return Ok(Response);
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
            return Ok(Group);
        }

        [HttpGet("GetAllGroupInvitee",Name = "GetAllGroupInvitee")]
        public async Task<ActionResult> GetAllGroupInvitee()
        {
            var dto = await _mediator.Send(new GetAllGroupInviteeQuery());

            return Ok(dto);
        }
    }
}
