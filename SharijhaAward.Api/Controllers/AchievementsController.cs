using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.Achievements.Commands.CreateAchievement;
using SharijhaAward.Application.Features.Achievements.Commands.UpdateAchievement;
using SharijhaAward.Application.Features.Achievements.Commands.UpdateAchievementById;
using SharijhaAward.Application.Features.Achievements.Queries.AcceptOnAchievement;
using SharijhaAward.Application.Features.Achievements.Queries.GetAchievementsById;
using SharijhaAward.Application.Features.Achievements.Queries.GetAchievementsPage;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
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

        [HttpGet("{userId}", Name = "GetAchievementsById")]
        public async Task<IActionResult> GetAchievementsById(int userId)
        {
            var token = HttpContext.Request.Headers.Authorization;

            var response = await _mediator.Send(new GetAchievementsByIdQuery()
            {
                token = token!,
                UserId = userId
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

        [HttpPut("UpdateAchievementById", Name = "UpdateAchievementById")]
        public async Task<IActionResult> UpdateAchievementById(UpdateAchievementByIdCommand command)
        {
            var token = HttpContext.Request.Headers.Authorization;
            
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

        [HttpPut("AcceptOnAchievement", Name = "AcceptOnAchievement")]
        public async Task<IActionResult> AcceptOnAchievement(AcceptOnAchievementQuery query)
        {
            var token = HttpContext.Request.Headers.Authorization;
            
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            query.token = token!;
            query.lang = language!;

            var response = await _mediator.Send(query);

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
