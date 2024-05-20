using Aspose.Pdf.Operators;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitrator;
using SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitratorCategory;
using SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitratorClass;
using SharijhaAward.Application.Features.Arbitrators.Commands.DeleteArbitrator;
using SharijhaAward.Application.Features.Arbitrators.Commands.DeleteArbitratorCategory;
using SharijhaAward.Application.Features.Arbitrators.Commands.DeleteArbitratorClass;
using SharijhaAward.Application.Features.Arbitrators.Commands.UpdateArbitrator;
using SharijhaAward.Application.Features.Arbitrators.Queries.ExportToExcel;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorsByFormId;
using SharijhaAward.Application.Features.Coordinators.Commands.DeleteCoordinator;
using SharijhaAward.Application.Features.Coordinators.Commands.UpdateCoordinator;
using SharijhaAward.Application.Features.Coordinators.Queries.ExportToExcel;
using SharijhaAward.Application.Features.Coordinators.Queries.GetAllCoordinators;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForView;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    // [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class ArbitratorsController : ControllerBase
    {
        private readonly IMediator _Mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public ArbitratorsController(IMediator Mediator,
            IWebHostEnvironment WebHostEnvironment)
        {
            _Mediator = Mediator;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost("CreateArbitrator")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateArbitrator([FromBody] CreateArbitratorCommand CreateArbitratorCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateArbitratorCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            CreateArbitratorCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "\\DynamicFiles\\";

            BaseResponse<int>? Response = await _Mediator.Send(CreateArbitratorCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteArbitrator/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteArbitrator(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteArbitratorCommand()
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
        [HttpPut("UpdateArbitrator")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateArbitrator([FromBody] UpdateArbitratorCommand UpdateArbitratorCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateArbitratorCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            UpdateArbitratorCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "\\DynamicFiles\\";

            BaseResponse<object>? Response = await _Mediator.Send(UpdateArbitratorCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllArbitrators")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllArbitrators([FromQuery] GetAllArbitratorsQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<ArbitratorsListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetArbitratorById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetArbitratorById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetArbitratorByIdResponse> Response = await _Mediator.Send(new GetArbitratorByIdQuery()
            {
                ArbitratorId = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteArbitratorClass")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteArbitratorClass(int ArbitratorId, int EducationalClassId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteArbitratorClassCommand()
            {
                ArbitratorId = ArbitratorId,
                EducationalClassId = EducationalClassId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("CreateArbitratorClass")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateArbitratorClass(CreateArbitratorClassCommand CreateArbitratorClassCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateArbitratorClassCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(CreateArbitratorClassCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("CreateArbitratorCategory")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateArbitratorCategory(CreateArbitratorCategoryCommand CreateArbitratorCategoryCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateArbitratorCategoryCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(CreateArbitratorCategoryCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteArbitratorCategory/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteArbitratorCategory(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteArbitratorCategoryCommand()
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

        [HttpGet("GetAllArbitratorsByFormId/{formId}", Name = "GetAllArbitratorsByFormId")]
        public async Task<IActionResult> GetAllArbitratorsByFormId(int formId)
        {
            string token = HttpContext.Request.Headers.Authorization!;

            if(token.IsNullOrEmpty())
            {
                return Unauthorized();
            }

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

           
            var Response = await _Mediator.Send(new GetArbitratorsByFormIdQuery()
            {
                formId = formId,
                lang = HeaderValue!,
                token = token
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpGet("ArbitratorExportToExcel", Name = "ArbitratorExportToExcel")]
        public async Task<IActionResult> ArbitratorExportToExcel()
        {
            var response = await _Mediator.Send(new ArbitratorExportToExcelQuery());

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Arbitrators.xlsx"),
                _ => BadRequest(response)
            };
        }
    }
}
