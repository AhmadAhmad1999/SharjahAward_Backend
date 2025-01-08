using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.ChangeAdvancedFormBuilderStatus;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.CreateAdvancedFormBuilder;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.CreateVirtualTableFroSection;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.DeleteAdvancedFormBuilder;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.DeleteVirtualTableFroSection;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.UpdateAdvancedFormBuilder;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.UpdateVirtualTableFroSection;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAdvancedFormBuilderById;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllAdvancedFormBuilderForDependency;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllAdvancedFormBuildersBySectionId;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllInputedAdvancedFormsByVirtualTableForSectionId;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllListAdvancedFormBuilders;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllVirtualTables;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAnalysisByVirtualTableForSectionId;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetInputedAdvancedFormsByVirtualTableId;
using SharijhaAward.Application.Helpers.AddAdvancedFormBuilderValue;
using SharijhaAward.Application.Helpers.AddAdvancedFormBuilderValueForSave;
using SharijhaAward.Application.Helpers.ExportReportForAdvancedFormBuilder;
using SharijhaAward.Application.Responses;
using System.Text;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class AdvancedFormBuilderController : ControllerBase
    {
        private readonly IMediator _Mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public AdvancedFormBuilderController(IMediator Mediator,
            IWebHostEnvironment WebHostEnvironment)
        {
            _Mediator = Mediator;
            _WebHostEnvironment = WebHostEnvironment;
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
                if (Response.data! != null 
                    ? Response.data!.Any()
                    : false)
                {
                    string json = JsonConvert.SerializeObject(Response.data![0]);
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
                        200 => Ok(),
                        404 => NotFound(),
                        _ => BadRequest()
                    };
                }
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
        [HttpGet("GetAllListAdvancedFormBuilders")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllListAdvancedFormBuilders(int SectionId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllListAdvancedFormBuildersListVM>> Response = await _Mediator.Send(new GetAllListAdvancedFormBuildersQuery()
            {
                SectionId = SectionId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPatch("ChangeAdvancedFormBuilderStatus/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ChangeAdvancedFormBuilderStatus(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new ChangeAdvancedFormBuilderStatusCommand()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("CreateNewAdvancedFormBuilder")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateNewAdvancedFormBuilder([FromBody] CreateAdvancedFormBuilderCommand CreateAdvancedFormBuilderCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            CreateAdvancedFormBuilderCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(CreateAdvancedFormBuilderCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("CreateVirtualTableFroSection")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateVirtualTableFroSection([FromBody] CreateVirtualTableFroSectionCommand CreateVirtualTableFroSectionCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            CreateVirtualTableFroSectionCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(CreateVirtualTableFroSectionCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteAdvancedFormBuilder/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteAdvancedFormBuilder(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteAdvancedFormBuilderCommand()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteVirtualTableFroSection/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteVirtualTableFroSection(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteVirtualTableFroSectionCommand()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("UpdateAdvancedFormBuilder")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateAdvancedFormBuilder([FromBody] UpdateAdvancedFormBuilderCommand UpdateAdvancedFormBuilderCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateAdvancedFormBuilderCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(UpdateAdvancedFormBuilderCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAdvancedFormBuilderById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAdvancedFormBuilderById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetAdvancedFormBuilderByIdDto> Response = await _Mediator.Send(new GetAdvancedFormBuilderByIdQuery()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllAdvancedFormBuilderForDependency")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAdvancedFormBuilderForDependency(int VirtualTableForSectionId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllAdvancedFormBuilderForDependencyListVM>> Response = await _Mediator.Send(new GetAllAdvancedFormBuilderForDependencyQuery()
            {
                VirtualTableForSectionId = VirtualTableForSectionId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllAdvancedFormBuildersBySectionId")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAdvancedFormBuildersBySectionId([FromQuery] GetAllAdvancedFormBuildersBySectionIdQuery GetAllAdvancedFormBuildersBySectionIdQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllAdvancedFormBuildersBySectionIdQuery.lang = HeaderValue;

            BaseResponse<List<AdvancedFormBuilderListVM>> Response = await _Mediator.Send(GetAllAdvancedFormBuildersBySectionIdQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("AddAdvancedFormBuilderValue")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            AddAdvancedFormBuilderValue([FromForm] AddAdvancedFormBuilderValueCommand AddAdvancedFormBuilderValueCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            AddAdvancedFormBuilderValueCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            AddAdvancedFormBuilderValueCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "/AdvancedFormsFiles/";
            BaseResponse<AddAdvancedFormBuilderValueResponse>? Response = await _Mediator.Send(AddAdvancedFormBuilderValueCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("AddAdvancedFormBuilderValueForSave")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            AddAdvancedFormBuilderValueForSave([FromForm] AddAdvancedFormBuilderValueForSaveCommand AddAdvancedFormBuilderValueForSaveCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            AddAdvancedFormBuilderValueForSaveCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            AddAdvancedFormBuilderValueForSaveCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "/AdvancedFormsFiles/";
            BaseResponse<int> Response = await _Mediator.Send(AddAdvancedFormBuilderValueForSaveCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllVirtualTables")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllVirtualTables([FromQuery] GetAllVirtualTablesQuery GetAllVirtualTablesQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllVirtualTablesQuery.lang = HeaderValue;

            BaseResponse<List<GetAllVirtualTablesListVM>> Response = await _Mediator.Send(GetAllVirtualTablesQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("UpdateVirtualTableFroSection")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateVirtualTableFroSection([FromBody] UpdateVirtualTableFroSectionCommand UpdateVirtualTableFroSectionCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateVirtualTableFroSectionCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(UpdateVirtualTableFroSectionCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAnalysisByVirtualTableForSectionId")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAnalysisByVirtualTableForSectionId(int VirtualTableForSectionId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAnalysisByVirtualTableForSectionIdListVM>> Response = await _Mediator.Send(new GetAnalysisByVirtualTableForSectionIdQuery()
            {
                VirtualTableForSectionId = VirtualTableForSectionId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllInputedAdvancedFormsByVirtualTableForSectionId")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllInputedAdvancedFormsByVirtualTableForSectionId([FromQuery] GetAllInputedAdvancedFormsByVirtualTableForSectionIdQuery GetAllInputedAdvancedFormsByVirtualTableForSectionIdQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllInputedAdvancedFormsByVirtualTableForSectionIdQuery.lang = HeaderValue;

            BaseResponse<GetAllInputedAdvancedFormsByVirtualTableForSectionIdListVM> Response = 
                await _Mediator.Send(GetAllInputedAdvancedFormsByVirtualTableForSectionIdQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetInputedAdvancedFormsByVirtualTableId")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetInputedAdvancedFormsByVirtualTableId(int VirtualTableForSectionId, int VirtualTableId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetInputedAdvancedFormsByVirtualTableIdDto> Response = await _Mediator.Send(new GetInputedAdvancedFormsByVirtualTableIdQuery()
            {
                VirtualTableForSectionId = VirtualTableForSectionId,
                VirtualTableId = VirtualTableId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
