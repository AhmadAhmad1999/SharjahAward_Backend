using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Rewards.Commands.CreateReward;
using SharijhaAward.Application.Features.Rewards.Commands.DeleteReward;
using SharijhaAward.Application.Features.Rewards.Commands.UpdateReward;
using SharijhaAward.Application.Features.Rewards.Queries.GetAllRewards;
using SharijhaAward.Application.Features.Rewards.Queries.GetRewardById;
using SharijhaAward.Api.Logger;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
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
        public async Task<IActionResult> GetAllRewards([FromQuery] GetAllRewardsQuery query)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            query.lang = Language!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("{Id}", Name = "GetRewardById")]
        public async Task<IActionResult> GetRewardById(int Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetRewardByIdQuery
            {
                lang = Language!,
                Id = Id,
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
