using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using SharijhaAward.Application.Helpers.ExportReportForAdvancedFormBuilder;
using SharijhaAward.Application.Responses;
using System.Text;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvancedFormBuilderController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public AdvancedFormBuilderController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("ExportReportForAdvancedFormBuilder")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ExportReportForAdvancedFormBuilder([FromBody] ExportReportForAdvancedFormBuilderCommand ExportReportForAdvancedFormBuilderCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            ExportReportForAdvancedFormBuilderCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<List<object>> Response = await _Mediator.Send(ExportReportForAdvancedFormBuilderCommand);

            if (ExportReportForAdvancedFormBuilderCommand.ExportDataToExcel)
            {
                string json = JsonConvert.SerializeObject(Response.data!);
                byte[] bytes = Encoding.UTF8.GetBytes(json);

                return Response.statusCode switch
                {
                    404 => NotFound(Response),
                    200 => File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"{Response.message}.xlsx"),
                    _ => BadRequest(Response)
                };
            }
            else
            {
                return Response.statusCode switch
                {
                    200 => Ok(Response),
                    404 => NotFound(Response),
                    _ => BadRequest(Response)
                };
            }
        }
    }
}
