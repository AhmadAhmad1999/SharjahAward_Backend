using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.AwardSponsorsPage.Commands.CreateAwardSponsor;
using SharijhaAward.Application.Features.AwardSponsorsPage.Commands.DeleteAwardSponsor;
using SharijhaAward.Application.Features.AwardSponsorsPage.Commands.UpdateAwardSponsor;
using SharijhaAward.Application.Features.AwardSponsorsPage.Queries.GetAwardSponsor;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.AwardSponsorsPage.Queries.GetAwardSponsorById;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class AwardSponsorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AwardSponsorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateAwardSponsor")]
        public async Task<IActionResult> CreateAwardSponsor([FromForm] CreateAwardSponsorCommand command)
        {
            //get Language from header
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

        [HttpPut(Name = "UpdateAwardSponser")]
        public async Task<IActionResult> UpdateAwardSponser([FromForm] UpdateAwardSponsorCommand command)
        {
            //get Language from header
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

        [HttpDelete("{Id}", Name = "DeleteAwardSponser")]
        public async Task<IActionResult> DeleteAwardSponser(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteAwardSponsorCommand()
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

        [HttpGet(Name = "GetAwardSponser")]
        public async Task<IActionResult> GetAwardSponser()
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAwardSponsorQuery()
            {
                lang = Language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }
        
        [HttpGet("{Id}", Name = "GetAwardSponserById")]
        public async Task<IActionResult> GetAwardSponserById(int Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAwardSponsorByIdQuery()
            {
                lang = Language!,
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
