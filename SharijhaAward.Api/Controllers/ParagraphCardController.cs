using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Commands.CreateParagraphCard;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Commands.DeleteParagraphCard;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Commands.UpdateParagraphCard;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Queries.GetAllParagraphCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Queries.GetParagraphCardById;

using SharijhaAward.Api.Logger;

namespace SharijhaAward.Api.Controllers
{
    // [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class ParagraphCardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ParagraphCardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateParagraphCard")]
        public async Task<IActionResult> CreateParagraphCard([FromForm] CreateParagraphCardCommand command)
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

        [HttpDelete("{Id}", Name = "DeleteParagraphCard")]
        public async Task<IActionResult> DeleteParagraphCard(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteParagraphCardCommand()
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

        [HttpPut(Name = "UpdateParagraphCard")]
        public async Task<IActionResult> UpdateParagraphCard([FromForm] UpdateParagraphCardCommand command)
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

        [HttpGet("GetAllParagraphCard/{PageId}", Name = "GetAllParagraphCard")]
        public async Task<IActionResult> GetAllParagraphCard(int PageId)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllParagraphCardsByPageIdQuery()
            {
                PageId = PageId,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("{Id}", Name = "GetParagraphCardById")]
        public async Task<IActionResult> GetParagraphCardById(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetParagraphCardByIdQuery()
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
