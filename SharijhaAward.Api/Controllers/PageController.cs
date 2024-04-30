using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.PageStructures.Pages.Commands.CreatePage;
using SharijhaAward.Application.Features.PageStructures.Pages.Commands.DeletePage;
using SharijhaAward.Application.Features.PageStructures.Pages.Commands.UpdatePage;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetAllMainPages;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageById;

namespace SharijhaAward.Api.Controllers
{
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
        public async Task<IActionResult> CreatePage(CreatePageCommand command)
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

        [HttpGet("GetAllMainPages", Name = "GetAllMainPages")]
        public async Task<IActionResult> GetAllPage()
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllMainPagesQuery()
            {
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
    }
}
