using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.PageStructures.TextCards.Commands.CreateTextCard;
using SharijhaAward.Application.Features.PageStructures.TextCards.Commands.DeleteTextCard;
using SharijhaAward.Application.Features.PageStructures.TextCards.Commands.UpdateTextCard;
using SharijhaAward.Application.Features.PageStructures.TextCards.Queries.GetAllTextCard;
using SharijhaAward.Application.Features.PageStructures.TextCards.Queries.GetAllTextCardDashborad;
using SharijhaAward.Application.Features.PageStructures.TextCards.Queries.GetTextCardById;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class TextCardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TextCardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateTextCard")]
        public async Task<IActionResult> CreateTextCard(CreateTextCardCommand command)
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

        [HttpDelete("{Id}", Name = "DeleteTextCard")]
        public async Task<IActionResult> DeleteTextCard(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];



            var response = await _mediator.Send(new DeleteTextCardCommand()
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

        [HttpPut(Name = "UpdateTextCard")]
        public async Task<IActionResult> UpdateCircualr(UpdateTextCardCommand command)
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

        [HttpGet(Name = "GetAllTextCard")]
        public async Task<IActionResult> GetAllTextCard(int? pageId, int page = 1, int perPage = 10)
        {
            var language = HttpContext.Request.Headers["lang"];

            var token = HttpContext.Request.Headers.Authorization;
            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }

            var response = await _mediator.Send(new GetAllTextCardsQuery()
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

        [HttpGet("{Id}", Name = "GetTextCardById")]
        public async Task<IActionResult> GetTextCardById(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetTextCardByIdQuery()
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

        [HttpGet("GetAllTextCardDashboard/{pageId}", Name = "GetAllTextCardDashboard")]
        public async Task<IActionResult> GetAllTextCardDashboard(int? pageId, int page = 1, int perPage = 10)
        {
            var language = HttpContext.Request.Headers["lang"];

            var token = HttpContext.Request.Headers.Authorization;
            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }

            var response = await _mediator.Send(new GetAllTextCardDashboradQuery()
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
