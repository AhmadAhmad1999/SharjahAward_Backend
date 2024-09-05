using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Circulars.Command.CreateCircular;
using SharijhaAward.Application.Features.Circulars.Command.DeleteCircular;
using SharijhaAward.Application.Features.Circulars.Command.UpdateCircular;
using SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars;
using SharijhaAward.Application.Features.Circulars.Queries.GetCircularById;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Commands.CreateDarkCard;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Commands.DeleteDarkCard;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Commands.UpdateDarkCard;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetAllDarkCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetDarkCardById;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetAllDarkCardsDashboard;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class DarkCardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DarkCardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateDarkCard")]
        public async Task<IActionResult> CreateDarkCard( CreateDarkCardCommand command)
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

        [HttpDelete("{Id}", Name = "DeleteDarkCard")]
        public async Task<IActionResult> DeleteDarkCard(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteDarkCardCommand()
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

        [HttpPut(Name = "UpdateDarkCard")]
        public async Task<IActionResult> UpdateDarkCard(UpdateDarkCardCommand command)
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

        [HttpGet("GetAllDarkCard/{PageId}", Name = "GetAllDarkCard")]
        public async Task<IActionResult> GetAllDarkCard(int PageId)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllDarkCardsByPageIdQuery()
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

        [HttpGet("{Id}", Name = "GetDarkCardById")]
        public async Task<IActionResult> GetDarkCardById(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetDarkCardByIdQuery()
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

        [HttpGet("GetAllDarkCardDashboard/{PageId}", Name = "GetAllDarkCardDashboard")]
        public async Task<IActionResult> GetAllDarkCardDashboard(int PageId)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllDarkCardsDashboardQuery()
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
    }
}
