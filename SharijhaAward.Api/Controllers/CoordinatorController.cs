using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinator;
using SharijhaAward.Application.Features.Coordinators.Queries.AddCordinatorToEduEntity;
using SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById;
using SharijhaAward.Application.Features.Coordinators.Queries.SearchForCoordinator;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CoordinatorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateCoordinator")]
        public async Task<IActionResult> CreateCoordinator([FromForm] CreateCoordinatorCommand command)
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
        [HttpGet("{CoordinatorId}" ,Name="GetCoordinatorById")]
        public async Task<IActionResult> GetCoordinatorById(Guid CoordinatorId)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetCoordinatorByIdQuery()
            {
                CoordinatorId = CoordinatorId,
                lang = Language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("SearchForCoordinators",Name = "SearchForCoordinators")]
        public async Task<IActionResult> SearchForCoordinators([FromQuery] SearchForCoordinatorQuery query)
        {
            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPost("AddCoordinatorToEduEntity",Name = "AddCoordinatorToEduEntity")]
        public async Task<IActionResult> AddCoordinatorToEduEntity(AddCoordinatorToEduEntityQuery query)
        {
            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
    }
}
