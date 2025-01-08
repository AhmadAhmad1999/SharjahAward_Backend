using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.Cycles.Commands.CreateCycle;
using SharijhaAward.Application.Features.Cycles.Commands.DeleteCycle;
using SharijhaAward.Application.Features.Cycles.Commands.UpdateCycle;
using SharijhaAward.Application.Features.Cycles.Queries.GetAllCycles;
using SharijhaAward.Application.Features.Cycles.Queries.GetCycleById;
using SharijhaAward.Application.Features.Cycles.Queries.GetLimteNumberOfCategories;
using SharijhaAward.Application.Responses;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.Cycles.Queries.ExportToExcel;
using SharijhaAward.Application.Features.Cycles.Queries.CycleImportLastData;
using SharijhaAward.Application.Features.Cycles.Queries.GetActiveCycle;
using SharijhaAward.Application.Features.Cycles.Commands.ImportFromOldCycle;
using SharijhaAward.Application.Features.Cycles.Queries.GetAllCategoriesWithAllItsData;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class CycleController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public CycleController(IMediator mediator)
        {
            _Mediator = mediator;
        }
        [HttpPost(Name = "CreateCycle")]
        public async Task<IActionResult> CreateCycle([FromBody] CreateCycleCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            command.lang = Language!;
            var response = await _Mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPut(Name = "UpdateCycle")]
        public async Task<IActionResult> UpdateCycle(UpdateCycleCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            command.lang = Language!;

            var response = await _Mediator.Send(command);
            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("{Id}", Name = "GetCycleById")]
        public async Task<IActionResult> GetCycleById(int Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _Mediator.Send(
                new GetCycleByIdQuery
                {
                    Id = Id,
                    lang = Language!
                });
            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet(Name = "GetAllCycle")]
        public async Task<IActionResult> GetAllCycle([FromQuery] GetAllCyclesQuery query)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            query.lang = Language!;

            //get data from mediator
            var response = await _Mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        
        [HttpGet("GetLimitedNumberOfCategories", Name = "GetLimitedNumberOfCategories")]
        public async Task<IActionResult> GetLimitedNumberOfCategories()
        {
            //get data from mediator
            var response = await _Mediator.Send(new GetLimteNumberOfCategoriesQuery());

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpDelete("{id}" ,Name="DeleteCycle")]
        public async Task<IActionResult> DeleteCycle(int id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteCycleCommand()
            {
                Id = id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpGet("CycleExportToExcel", Name = "CycleExportToExcel")]
        public async Task<IActionResult> CycleExportToExcel()
        {
            var response = await _Mediator.Send(new ExportToExcelQuery());

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Cycles.xlsx"),
                _ => BadRequest(response)
            };
        }
        [HttpPost("ImportDataForCycle", Name = "ImportDataForCycle")]
        public async Task<IActionResult> ImportDataForCycle([FromBody] CycleImportLastDataQuery query)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            query.lang = Language!;
            var response = await _Mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("GetActiveCycle")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetActiveCycle()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<bool> Response = await _Mediator.Send(new GetActiveCycleQuery()
            {
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("ImportFromOldCycle")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ImportFromOldCycle([FromBody] ImportFromOldCycleCommand ImportFromOldCycleCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            ImportFromOldCycleCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object> Response = await _Mediator.Send(ImportFromOldCycleCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllCategoriesWithAllItsData")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllCategoriesWithAllItsData(int CycleId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            string? Language = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<List<MainCategoryDataDto>> Response = await _Mediator.Send(new GetAllCategoriesWithAllItsDataQuery
            {
                CycleId = CycleId,
                lang = Language
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
