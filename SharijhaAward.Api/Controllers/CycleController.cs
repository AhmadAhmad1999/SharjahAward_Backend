using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Cycles.Commands.CreateCycle;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CycleController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CycleController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult> CreateCycle([FromBody] CreateCycleCommand command)
        {
            var rsponse = await _mediator.Send(command);
            return StatusCode(201, new { data = rsponse } );
        }
    }
}
