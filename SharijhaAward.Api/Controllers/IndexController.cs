using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.Indexes.Commands.CreateIndex;
using SharijhaAward.Application.Features.Indexes.Commands.DeleteIndex;
using SharijhaAward.Application.Features.Indexes.Commands.UpdateIndex;
using SharijhaAward.Application.Features.Indexes.Queries.GetAllIndexes;
using SharijhaAward.Application.Features.Indexes.Queries.GetIndexById;


namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private readonly IMediator _mediator;

        public IndexController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateIndex")]
        public async Task<IActionResult> CreateIndex(CreateIndexCommand command)
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

        [HttpDelete("{Id}", Name = "DeleteIndex")]
        public async Task<IActionResult> DeleteIndex(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];



            var response = await _mediator.Send(new DeleteIndexCommand()
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

        [HttpPut(Name = "UpdateIndex")]
        public async Task<IActionResult> UpdateCircualr(UpdateIndexCommand command)
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

        [HttpGet(Name = "GetAllIndex")]
        public async Task<IActionResult> GetAllIndex(int page = 1, int perPage = 10)
        {
            var language = HttpContext.Request.Headers["lang"];

            var token = HttpContext.Request.Headers.Authorization;

            var response = await _mediator.Send(new GetAllIndexesQuery()
            {
                page = page,
                perPage = perPage,
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("{Id}", Name = "GetIndexById")]
        public async Task<IActionResult> GetIndexById(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetIndexByIdQuery()
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
