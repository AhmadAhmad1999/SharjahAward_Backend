using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
    public class PersonalInviteeController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public PersonalInviteeController(IMediator mediator, IWebHostEnvironment WebHostEnvironment)
        {
            _mediator = mediator;
            _WebHostEnvironment = WebHostEnvironment;
        }

        [HttpPost(Name = "AddPersonalInvitee")]
        public async Task<ActionResult<string>> AddPersonalInvitee([FromBody] CreatePersonalInviteeCommand createPersonalInviteeCommand)
        {
            var headerValue = HttpContext.Request.Headers["lang"];
            if (!string.IsNullOrWhiteSpace(headerValue))
                createPersonalInviteeCommand.lang = headerValue;

            createPersonalInviteeCommand.ImagePath = _WebHostEnvironment.WebRootPath;
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
            
            return Json(new {data = Personal });
            
        }

        [HttpGet(Name = "GetAllPersonalInvitee")]
        public async Task<ActionResult> GetAllPersonalInvitee(int page , int perPage)
        {
            var dto = await _mediator.Send(new GetAllPersonalInviteeQuery());
            if (perPage == 0)
                perPage = 10;
            if(perPage == -1)
                 return Ok(
                  new
                  {
                      data = dto,
                      message = "Retrieved successfully.",
                      status = true,
                  });
            
            var totalCount=dto.Count;
            var totalPage = (int) Math.Ceiling((decimal)totalCount / perPage);
            var dataPerPage = dto
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();
                
            return Json(
                new 
                { 
                    data = dataPerPage ,
                    message = "Retrieved successfully.",
                    status = true,
                    pagination = 
                    new { 
                        current_page = page ,
                        last_page = totalPage,
                        total_row = totalCount,
                        per_page = perPage
                    } 
                });
        }
        [HttpPost("ConfirmAttendancePersonal", Name = "ConfirmAttendancePersonal")]
        public async Task<ActionResult> ConfirmAttendancePersonal([FromBody] ConfirmAttendancePersonalQuery personalQuery)
        {
            var respone = await _mediator.Send(new ConfirmAttendancePersonalQuery()
            { 
                Id = personalQuery.Id,
            });

            return Ok(respone);
        }
    }
}
