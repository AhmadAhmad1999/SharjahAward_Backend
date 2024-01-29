using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.DeletePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.UpdatePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetAllPersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalInviteeById;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInviteeController : Controller
    {
        private readonly IMediator _mediator;

        public PersonalInviteeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "AddPersonalInvitee")]
        public async Task<ActionResult<Guid>> AddPersonalInvitee([FromBody] CreatePersonalInviteeCommand createPersonalInviteeCommand)
        {
            var response = await _mediator.Send(createPersonalInviteeCommand);
            return Ok(response);
        }

        [HttpPut(Name = "UpdatePersonalInvitee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdatePersonalInvitee([FromBody] UpdatePersonalInviteeCommand updatePersonalInviteeCommand)
        {

            await _mediator.Send(updatePersonalInviteeCommand);
            return Ok(Response);
        }

        [HttpDelete(Name = "DeletePersonalInvitee")]
        public async Task<ActionResult> DeletePersonalInvitee(Guid id)
        {
            DeletePersonalInviteeCommand deletePersonalInviteeCommand = new DeletePersonalInviteeCommand()
            {
                Id = id
            };
            await _mediator.Send(deletePersonalInviteeCommand);
            return Ok(Response);
        }

        [HttpGet("{id}", Name = "GetPersonalInviteeById")]
        public async Task<ActionResult<GetPersonalInviteeByIdQuery>> GetById(Guid id)
        {
            PersonalInviteeVM? Personal = await _mediator
                .Send(new GetPersonalInviteeByIdQuery
                {
                    Id = id
                });
            return Ok(Personal);
        }

        [HttpGet(Name = "GetAllPersonalInvitee")]
        public async Task<ActionResult> GetAllPersonalInvitee()
        {
           var dto = await _mediator.Send(new GetAllPersonalInviteeQuery());

            return Ok(dto);
        }
    }
}
