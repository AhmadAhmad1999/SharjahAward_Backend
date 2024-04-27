using Aspose.Html.Dom.Css;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Achievements.Commands.CreateAchievement;
using SharijhaAward.Application.Features.Achievements.Commands.UpdateAchievement;
using SharijhaAward.Application.Features.Achievements.Queries.GetAchievementsPage;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AchievementsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AchievementsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateAchievements")]
        public async Task<IActionResult> CreateAchievements([FromBody] CreateAchievementCommand command)
        {
            var token = HttpContext.Request.Headers.Authorization;
            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }
            command.token = token!;
            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                401 => Unauthorized(),
                _ => BadRequest(response)
            };
        }

        [HttpGet(Name = "GetAchievements")]
        public async Task<IActionResult> GetAchievements()
        {
            var token = HttpContext.Request.Headers.Authorization;
            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }

            var response = await _mediator.Send(new GetAchievementsPageQuery()
            {
                token = token!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                401 => Unauthorized(),
                _ => BadRequest(response)
            };
        }
        [HttpPut(Name = "UpdateAchievement")]
        public async Task<IActionResult> UpdateAchievement(UpdateAchievementCommand command)
        {
            var token = HttpContext.Request.Headers.Authorization;
            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            command.token = token!;
            command.lang = language!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                401 => Unauthorized(),
                _ => BadRequest(response)
            };
        }
    }
}
