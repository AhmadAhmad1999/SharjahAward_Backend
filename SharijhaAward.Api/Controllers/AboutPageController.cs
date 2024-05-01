using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.AboutAwardPages.Commands.CreateAboutPage;
using SharijhaAward.Application.Features.AboutAwardPages.Commands.CreateGoal;
using SharijhaAward.Application.Features.AboutAwardPages.Commands.UpdateAboutPage;
using SharijhaAward.Application.Features.AboutAwardPages.Commands.UpdateGoal;
using SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPage;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutPageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutPageController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost(Name = "CreateAboutPage")]
        public async Task<IActionResult> CreateAboutPage([FromForm] CreateAboutPageCommand command)
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
        [HttpPost("CreateGoal", Name = "CreateGoal")]
        public async Task<IActionResult> CreateGoal([FromBody] CreateGoalCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }
        [HttpGet(Name = "GetAboutAwardPage")]
        public async Task<IActionResult> GetAboutAwardPage()
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAboutPageQuery()
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

        [HttpPut(Name = "UpdateAboutPage")]
        public async Task<IActionResult> UpdateAboutPage([FromForm] UpdateAboutPageCommand command)
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
        [HttpPut("UpadteGoal", Name = "UpdateGoal")]
        public async Task<IActionResult> UpdateGoal(UpdateGoalCommand command)
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
    }
}
