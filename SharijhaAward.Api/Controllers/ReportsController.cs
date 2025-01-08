using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.AdvanceReports.Commands.CreateAdvanceReports;
using SharijhaAward.Application.Features.AdvanceReports.Queries.GetPropertyNames;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReportsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GenerateReport",Name = "GenerateReport")]
        public async Task<IActionResult> GenerateReport([FromQuery] CreateAdvanceReportsCommand command)
        {
            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }

        [HttpGet("GetPropertyNames", Name = "GetPropertyNames")]
        public async Task<IActionResult> GetPropertyNames()
        {
            var response = await _mediator.Send(new GetPropertyNamesQuery());

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }
    }
}
