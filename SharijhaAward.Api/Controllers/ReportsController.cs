using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.AdvanceReports.Commands.CreateAdvanceReports;
using SharijhaAward.Application.Features.AdvanceReports.Queries.GetPropertyNames;

namespace SharijhaAward.Api.Controllers
{
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
        public async Task<IActionResult> GenerateReport([FromQuery]
        string[] cycleColumns, [FromQuery] string[] categoryColumns, [FromQuery] string[] providedFormColumns)
        {
            var response = await _mediator.Send(new CreateAdvanceReportsCommand()
            {
                categoryColums = categoryColumns,
                cycleColums = cycleColumns,
                ProvidedFormColums = providedFormColumns
            });

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
