using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.EducationalEntities.Command.CreateEducationalEntity;
using SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntities;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationalEntityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EducationalEntityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateEducationalEntity")]
        public async Task<IActionResult> CreateEducationalEntity(CreateEducationalEntityCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            command.lang = Language!;

            var response = await _mediator.Send(command);
            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
            
        }
        [HttpGet(Name = "GetAllEducationalEntities")]
        public async Task<IActionResult> GetAllEducationalEntities()
        {
            var response = await _mediator.Send(new GetAllEducationalEntitiesCommand());

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
    }
}
