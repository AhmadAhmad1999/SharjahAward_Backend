using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.PageStructures.Pages.Commands.CreatePage;
using SharijhaAward.Application.Features.PageStructures.Pages.Commands.DeletePage;
using SharijhaAward.Application.Features.PageStructures.Pages.Commands.UpdatePage;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPagesWithSubPages;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageById;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageBySlug;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPages;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPagesInCell;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Responses;
using SharijhaAward.Application.Features.PageStructures.Pages.Commands.ReorderPages;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreatePage")]
        public async Task<IActionResult> CreatePage([FromForm] CreatePageCommand command)
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

        [HttpDelete("{Id}", Name = "DeletePage")]
        public async Task<IActionResult> DeletePage(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeletePageCommand()
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

        [HttpPut(Name = "UpdatePage")]
        public async Task<IActionResult> UpdatePage(UpdatePageCommand command)
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

        [HttpGet("GetMainPagesWithSubPages", Name = "GetMainPagesWithSubPages")]
        public async Task<IActionResult> GetMainPagesWithSubPages([FromQuery] GetMainPagesWithSubPagesQuery query)
        {
            var language = HttpContext.Request.Headers["lang"];

            query.lang = language!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("GetMainPages", Name = "GetMainPages")]
        public async Task<IActionResult> GetMainPages(int page = 1, int perPage = 10)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetMainPagesQuery()
            {
                page = page,
                perPage = perPage,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("GetPagesInCell", Name = "GetPagesInCell")]
        public async Task<IActionResult> GetPagesInCell(int page = 1, int perPage = 10)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetPagesInCellQuery()
            {
                page = page,
                perPage = perPage,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("{Id}", Name = "GetPageById")]
        public async Task<IActionResult> GetPageById(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetPageByIdQuery()
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

        [HttpGet("GetPageBySlug/{Slug}", Name = "GetPageBySlug")]
        public async Task<IActionResult> GetPageBySlug(string Slug)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetPageBySlugQuery()
            {
                lang = language!,
                Slug = Slug
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPost("ReorderPages")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ReorderPages([FromBody] ReorderPagesCommand ReorderPagesCommand)
        {
            if (!ReorderPagesCommand.ValidateUniqueness(out var ErrorMessage))
                return BadRequest(new BaseResponse<object> (ErrorMessage, false, 400));

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            ReorderPagesCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _mediator.Send(ReorderPagesCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
