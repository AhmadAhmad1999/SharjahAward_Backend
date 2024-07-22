using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.ArbitrationResults.Commands.ChangeArbitrationResultsStatus;
using SharijhaAward.Application.Features.ArbitrationResults.Queries.ExportArbitrationResultsToExcel;
using SharijhaAward.Application.Features.ArbitrationResults.Queries.GetAllArbitrationResults;
using SharijhaAward.Application.Features.Classes.Commands.UpdateClass;
using SharijhaAward.Application.Features.WinnersFeatures.Queries.ExportWinnersToExcel;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArbitrationResultsController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public ArbitrationResultsController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpGet("GetAllArbitrationResults")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllArbitrationResults(int? CategoryId, string? SubscriberName,
            int? CycleNumber, string? CategoryName, bool? EligibleToWin, int Page = 1, int PerPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllArbitrationResultsListVM>> Response = await _Mediator.Send(new GetAllArbitrationResultsQuery()
            {
                CategoryId = CategoryId,
                lang = HeaderValue!,
                page = Page,
                PerPage = PerPage,
                SubscriberName = SubscriberName,
                CycleNumber = CycleNumber,
                CategoryName = CategoryName,
                EligibleToWin = EligibleToWin
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("ChangeArbitrationResultsStatus")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ChangeArbitrationResultsStatus([FromBody] ChangeArbitrationResultsStatusCommand ChangeArbitrationResultsStatusCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            ChangeArbitrationResultsStatusCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(ChangeArbitrationResultsStatusCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpGet("ArbitrationResultsExportToExcel", Name = "ArbitrationResultsExportToExcel")]
        public async Task<IActionResult> ArbitrationResultsExportToExcel()
        {
            var response = await _Mediator.Send(new ExportArbitrationResultsToExcelQuery());

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ArbitrationResults.xlsx"),
                _ => BadRequest(response)
            };
        }
    }
}
