using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Commands.CreateImageCard;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Commands.DeleteImageCard;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Commands.UpdateImageCard;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetAllImageCards;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetAllImageCardsDashboard;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetImageCardById;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageCardController : ControllerBase
    {
        private readonly IMediator _mediator;


        public ImageCardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateImageCard")]
        public async Task<IActionResult> CreateImageCard([FromForm] CreateImageCardCommand command)
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

        [HttpDelete("{Id}", Name = "DeleteImageCard")]
        public async Task<IActionResult> DeleteImageCard(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];



            var response = await _mediator.Send(new DeleteImageCardCommand()
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

        [HttpPut(Name = "UpdateImageCard")]
        public async Task<IActionResult> UpdateCircualr([FromForm] UpdateImageCardCommand command)
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

        [HttpGet(Name = "GetAllImageCard")]
        public async Task<IActionResult> GetAllImageCard(int? pageId, int page = 1, int perPage = 10)
        {
            var language = HttpContext.Request.Headers["lang"];

            var token = HttpContext.Request.Headers.Authorization;
            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }

            var response = await _mediator.Send(new GetAllImageCardsQuery()
            {
                pageId = pageId,
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

        [HttpGet("{Id}", Name = "GetImageCardById")]
        public async Task<IActionResult> GetImageCardById(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetImageCardByIdQuery()
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

        [HttpGet("GetAllImageCardDashboard/{pageId}", Name = "GetAllImageCardDashboard")]
        public async Task<IActionResult> GetAllImageCardDashboard(int? pageId, int page = 1, int perPage = 10)
        {
            var language = HttpContext.Request.Headers["lang"];

            var token = HttpContext.Request.Headers.Authorization;
            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }

            var response = await _mediator.Send(new GetAllImageCardsDashboardQuery()
            {
                pageId = pageId,
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
    }
}
