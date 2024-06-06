using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.AwardStatistics.Commands.CreateAwardStatistic;
using SharijhaAward.Application.Features.AwardStatistics.Commands.DeleteAwardStatistic;
using SharijhaAward.Application.Features.AwardStatistics.Commands.UpdateAwardStatistic;
using SharijhaAward.Application.Features.AwardStatistics.Queries.GetAllAwardStatistics;
using SharijhaAward.Application.Features.AwardStatistics.Queries.GetAwardStatisticById;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class AwardStatisticController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AwardStatisticController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateAwardStatistic")]
        public async Task<IActionResult> CreateAwardStatistic(CreateAwardStatisticCommand command)
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

        [HttpDelete("{Id}", Name = "DeleteAwardStatistic")]
        public async Task<IActionResult> DeleteAwardStatistic(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];



            var response = await _mediator.Send(new DeleteAwardStatisticCommand()
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

        [HttpPut(Name = "UpdateAwardStatistic")]
        public async Task<IActionResult> UpdateCircualr(UpdateAwardStatisticCommand command)
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

        [HttpGet(Name = "GetAllAwardStatistics")]
        public async Task<IActionResult> GetAllAwardStatistics(int CycleId, int page = 1, int perPage = 10)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllAwardStatisticsQuery()
            {
                CycleId = CycleId,
                page = page,
                perPage = perPage,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("{Id}", Name = "GetAwardStatisticById")]
        public async Task<IActionResult> GetAwardStatisticById(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAwardStatisticByIdQuery()
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
    }
}
