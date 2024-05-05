using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Rewards.Commands.CreateReward;
using SharijhaAward.Application.Features.Rewards.Commands.DeleteReward;
using SharijhaAward.Application.Features.Rewards.Commands.UpdateReward;
using SharijhaAward.Application.Features.Rewards.Queries.GetAllRewards;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RewardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RewardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateReward")]
        public async Task<IActionResult> CreateReward(CreateRewardCommand command)
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

        [HttpPut(Name = "UpdateReward")]
        public async Task<IActionResult> UpdateReward(UpdateRewardCommand command)
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

        [HttpDelete("{Id}", Name = "DeleteReward")]
        public async Task<IActionResult> DeleteReward(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteRewardCommand()
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

        [HttpGet(Name = "GetAllRewards")]
        public async Task<IActionResult> GetAllRewards(int CategoryId)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllRewardsQuery
            {
                lang = Language!,
                CategoryId = CategoryId
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
