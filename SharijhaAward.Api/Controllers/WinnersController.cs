using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.WinnersFeatures.Commands.ConfirmSelectedWinningForms;
using SharijhaAward.Application.Features.WinnersFeatures.Commands.SelectWinningForms;
using SharijhaAward.Application.Features.WinnersFeatures.Queries.ExportWinnersToExcel;
using SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersDashboard;
using SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersForWebsite;
using SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevel;
using SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevelGroupedByClasses;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WinnersController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public WinnersController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPut("SelectWinningForms")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> SelectWinningForms([FromBody] SelectWinningFormsCommand SelectWinningFormsCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            SelectWinningFormsCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(SelectWinningFormsCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllWinnersDashboard")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllWinnersDashboard([FromQuery] GetAllWinnersDashboardQuery GetAllWinnersDashboardQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllWinnersDashboardQuery.lang = HeaderValue;

            BaseResponse<List<GetAllWinnersDashboardListVM>> Response = await _Mediator.Send(GetAllWinnersDashboardQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllWinnersForWebsite")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllWinnersForWebsite([FromQuery] GetAllWinnersForWebsiteQuery GetAllWinnersForWebsiteQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllWinnersForWebsiteQuery.lang = HeaderValue;

            BaseResponse<List<GetAllWinnersForWebsiteMainResponse>> Response = await _Mediator.Send(GetAllWinnersForWebsiteQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetWinnersByLevel")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetWinnersByLevel([FromQuery] GetWinnersByLevelQuery GetWinnersByLevelQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetWinnersByLevelQuery.lang = HeaderValue;

            BaseResponse<GetWinnersByLevelMainResponse> Response = await _Mediator.Send(GetWinnersByLevelQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetWinnersByLevelGroupedByClasses")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetWinnersByLevelGroupedByClasses([FromQuery] GetWinnersByLevelGroupedByClassesQuery GetWinnersByLevelGroupedByClassesQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetWinnersByLevelGroupedByClassesQuery.lang = HeaderValue;

            BaseResponse<List<GetWinnersByLevelGroupedByClassesListVM>> Response = await _Mediator.Send(GetWinnersByLevelGroupedByClassesQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("ConfirmSelectedWinningForms")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ConfirmSelectedWinningForms([FromBody] ConfirmSelectedWinningFormsCommand ConfirmSelectedWinningFormsCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            ConfirmSelectedWinningFormsCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(ConfirmSelectedWinningFormsCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpGet("WinnersExportToExcel", Name = "WinnersExportToExcel")]
        public async Task<IActionResult> AgendasExportToExcel()
        {
            var response = await _Mediator.Send(new ExportWinnersToExcelQuery());

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Winners.xlsx"),
                _ => BadRequest(response)
            };
        }
    }
}
