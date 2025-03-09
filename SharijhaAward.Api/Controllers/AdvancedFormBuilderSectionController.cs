using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.OpenAdvancedFormForAdd;
using SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.CreateAdvancedFormBuilderSection;
using SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.DeleteAdvancedFormBuilderSection;
using SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.ReorderAdvancedFormBuildersInsideTheSections;
using SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.UpdateAdvancedFormBuilderSection;
using SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAdvancedFormBuilderSectionById;
using SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAllAdvancedFormBuilderSectionsForAdd;
using SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAllAdvancedFormBuilderSectionsForView;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class AdvancedFormBuilderSectionController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public AdvancedFormBuilderSectionController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("CreateAdvancedFormBuilderSection")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            CreateAdvancedFormBuilderSection([FromBody] CreateAdvancedFormBuilderSectionCommand CreateAdvancedFormBuilderSectionCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            CreateAdvancedFormBuilderSectionCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(CreateAdvancedFormBuilderSectionCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteAdvancedFormBuilderSection/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteAdvancedFormBuilderSection(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteAdvancedFormBuilderSectionCommand()
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
        [HttpPost("ReorderAdvancedFormBuildersInsideTheSections")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            ReorderAdvancedFormBuildersInsideTheSections([FromBody] ReorderAdvancedFormBuildersInsideTheSectionsCommand ReorderAdvancedFormBuildersInsideTheSectionsCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            ReorderAdvancedFormBuildersInsideTheSectionsCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(ReorderAdvancedFormBuildersInsideTheSectionsCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("UpdateAdvancedFormBuilderSection")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateAdvancedFormBuilderSection([FromBody] UpdateAdvancedFormBuilderSectionCommand UpdateAdvancedFormBuilderSectionCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateAdvancedFormBuilderSectionCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            UpdateAdvancedFormBuilderSectionCommand.lang = HeaderValue!;

            BaseResponse<object> Response = await _Mediator.Send(UpdateAdvancedFormBuilderSectionCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAdvancedFormBuilderSectionById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAdvancedFormBuilderSectionById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetAdvancedFormBuilderSectionByIdDto> Response = await _Mediator.Send(new GetAdvancedFormBuilderSectionByIdQuery()
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
        [HttpGet("GetAllAdvancedFormBuilderSectionsForAdd/{PrivateHashKey}/{VirtualTableId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAdvancedFormBuilderSectionsForAdd(string PrivateHashKey, int? VirtualTableId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllAdvancedFormBuilderSectionsForAddListVM>> Response = await _Mediator.Send(new GetAllAdvancedFormBuilderSectionsForAddQuery()
            {
                lang = HeaderValue!,
                PrivateHashKey = PrivateHashKey,
                VirtualTableId = VirtualTableId
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllAdvancedFormBuilderSectionsForView")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAdvancedFormBuilderSectionsForView([FromQuery] GetAllAdvancedFormBuilderSectionsForViewQuery GetAllAdvancedFormBuilderSectionsForViewQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllAdvancedFormBuilderSectionsForViewQuery.lang = HeaderValue;

            BaseResponse<List<AdvancedFormBuilderSectionListVM>> Response = await _Mediator.Send(GetAllAdvancedFormBuilderSectionsForViewQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("OpenAdvancedFormForAdd")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> OpenAdvancedFormForAdd(int VirtualTableForSectionId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object> Response = await _Mediator.Send(new OpenAdvancedFormForAddCommand()
            {
                VirtualTableForSectionId = VirtualTableForSectionId,
                lang = HeaderValue
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
