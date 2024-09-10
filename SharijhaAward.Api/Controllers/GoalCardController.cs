using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Commands.CreateGoalCard;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Commands.DeleteGoalCard;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetGoalCardById;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Commands.CreateGoalCard;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsDashboard;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class GoalCardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GoalCardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateGoalCard")]
        public async Task<IActionResult> CreateGoalCard(CreateGoalCardCommand command)
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

        [HttpDelete("{Id}", Name = "DeleteGoalCard")]
        public async Task<IActionResult> DeleteGoalCard(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteGoalCardCommand()
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

        //[HttpPut(Name = "UpdateGoalCard")]
        //public async Task<IActionResult> UpdateGoalCard(UpdateGoalCardCommand command)
        //{
        //    var language = HttpContext.Request.Headers["lang"];

        //    command.lang = language!;

        //    var response = await _mediator.Send(command);

        //    return response.statusCode switch
        //    {
        //        200 => Ok(response),
        //        404 => NotFound(response),
        //        _ => BadRequest(response)
        //    };
        //}

        [HttpGet("GetAllGoalCard/{PageId}", Name = "GetAllGoalCard")]
        public async Task<IActionResult> GetAllGoalCard(int PageId)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllGoalCardsByPageIdQuery()
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

        [HttpGet("{Id}", Name = "GetGoalCardById")]
        public async Task<IActionResult> GetGoalCardById(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetGoalCardByIdQuery()
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

        [HttpGet("GetAllGoalCardDashboard/{PageId}", Name = "GetAllGoalCardDashboard")]
        public async Task<IActionResult> GetAllGoalCardDashboard(int PageId)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllGoalCardsDashboardQuery()
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
