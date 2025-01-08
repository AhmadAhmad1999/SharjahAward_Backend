using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinator;
using SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinatorEntity;
using SharijhaAward.Application.Features.Coordinators.Commands.DeleteCoordinator;
using SharijhaAward.Application.Features.Coordinators.Commands.DeleteCoordinatorEntity;
using SharijhaAward.Application.Features.Coordinators.Commands.UpdateCoordinator;
using SharijhaAward.Application.Features.Coordinators.Queries.ExportToExcel;
using SharijhaAward.Application.Features.Coordinators.Queries.GetAllCoordinators;
using SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById;
using SharijhaAward.Application.Features.Coordinators.Queries.SearchForCoordinator;
using SharijhaAward.Application.Responses;
using SharijhaAward.Api.Logger;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorByFormId;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatorController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public CoordinatorController(IMediator mediator,
            IWebHostEnvironment WebHostEnvironment)
        {
            _mediator = mediator;
            _WebHostEnvironment = WebHostEnvironment;
        }

        [HttpPost(Name = "CreateCoordinator")]
        public async Task<IActionResult> CreateCoordinator([FromForm] CreateCoordinatorCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            command.lang = Language!;

            command.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "/DynamicFiles/";

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("{CoordinatorId}" ,Name="GetCoordinatorById")]
        public async Task<IActionResult> GetCoordinatorById(int CoordinatorId)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetCoordinatorByIdQuery()
            {
                CoordinatorId = CoordinatorId,
                lang = Language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("SearchForCoordinators",Name = "SearchForCoordinators")]
        public async Task<IActionResult> SearchForCoordinators([FromQuery] SearchForCoordinatorQuery query)
        {
            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpPut("UpdateCoordinator")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateCoordinator([FromForm] UpdateCoordinatorCommand UpdateCoordinatorCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateCoordinatorCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            UpdateCoordinatorCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "/DynamicFiles/";

            BaseResponse<object>? Response = await _mediator.Send(UpdateCoordinatorCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteCoordinator/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteCoordinator(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _mediator.Send(new DeleteCoordinatorCommand()
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
        [HttpGet("GetAllCoordinators")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllCoordinators([FromQuery] GetAllCoordinatorsQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;
            
            BaseResponse<List<CoordinatorsListVM>> Response = await _mediator.Send(query);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpPost("CreateCoordinatorEntity")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateCoordinatorEntity(CreateCoordinatorEntityCommand command)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            command.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _mediator.Send(command);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpDelete("DeleteCoordinatorEntity/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteCoordinatorEntity(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _mediator.Send(new DeleteCoordinatorEntityCommand()
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

        [HttpGet("GetAllCoordinatorsByFormId/{formId}", Name = "GetAllCoordinatorsByFormId")]
        public async Task<IActionResult> GetAllCoordinatorsByFormId(int formId, int page = 1, int perPage = 10)
        {
            string token = HttpContext.Request.Headers.Authorization!;

            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";


            var Response = await _mediator.Send(new GetCoordinatorByFormIdQuery()
            {
                formId = formId,
                lang = HeaderValue!,
                token = token,
                page = page,
                perPage = perPage
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }


        [HttpGet("CoordinatorExportToExcel", Name="CoordinatorExportToExcel")]
        public async Task<IActionResult> CoordinatorExportToExcel()
        {
            var response = await _mediator.Send(new CoordinatorExportToExcelQuery());

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Coordinators.xlsx"),
                _ => BadRequest(Response)
            };
        }
    }
}
