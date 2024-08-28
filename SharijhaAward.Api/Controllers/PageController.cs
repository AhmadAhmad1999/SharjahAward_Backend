using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.PageStructures.Pages.Commands.CreatePage;
using SharijhaAward.Application.Features.PageStructures.Pages.Commands.DeletePage;
using SharijhaAward.Application.Features.PageStructures.Pages.Commands.UpdatePage;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPagesWithSubPages;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageById;

using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageBySlug;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPages;

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
        
    }
}
