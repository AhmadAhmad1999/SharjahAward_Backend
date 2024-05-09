using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Circulars.Command.CreateCircular;
using SharijhaAward.Application.Features.Circulars.Command.DeleteCircular;
using SharijhaAward.Application.Features.Circulars.Command.UpdateCircular;
using SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars;
using SharijhaAward.Application.Features.Circulars.Queries.GetCircularById;
using SharijhaAward.Api.Logger;

namespace SharijhaAward.Api.Controllers
{
    // [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class CircularController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CircularController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateCircular")]
        public async Task<IActionResult> CreateCircular([FromForm] CreateCircularCommand command)
        {
            var language = HttpContext.Request.Headers["lang"];

            command.lang = language!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpDelete("{Id}", Name = "DeleteCircular")]
        public async Task<IActionResult> DeleteCircular(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];



            var response = await _mediator.Send(new DeleteCircularCommand()
            {
                Id = Id,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpPut(Name = "UpdateCircular")]
        public async Task<IActionResult> UpdateCircualr([FromForm] UpdateCircularCommand command)
        {
            var language = HttpContext.Request.Headers["lang"];

            command.lang = language!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet(Name = "GetAllCircular")]
        public async Task<IActionResult> GetAllCircular(int page = 1, int pageSize = 10)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllCircularsQuery()
            {
                page = page,
                pageSize = pageSize
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("{Id}", Name = "GetCircularById")]
        public async Task<IActionResult> GetCircularById(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetCircularByIdQuery()
            {
                lang = language!,
                Id = Id
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
    }
}
