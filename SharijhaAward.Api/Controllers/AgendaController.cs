using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Agendas.Commands.CreateAgenda;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {
       private readonly IMediator _mediator;

        public AgendaController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost(Name= "AddAgenda")]
        public async Task<ActionResult> AddAgenda(CreateAgendaCommand command)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            command.lang = headerValue!;

            var response = await _mediator.Send(command);
            if(response.StatusCode == 404)
            {
                return NotFound(new
                {
                    response.Message,
                    response.StatusCode,
                    response.Success
                });
            }
            else if (response.StatusCode == 200)
            {
                return Ok(new
                {
                    response.Data,
                    response.Message,
                    response.StatusCode,
                    response.Success
                });
            }
            else return BadRequest(new
            {
                response.Message,
                response.StatusCode,
            });
        }
    }
}
