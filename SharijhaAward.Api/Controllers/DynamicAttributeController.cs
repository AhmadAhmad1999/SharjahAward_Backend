using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.ChangeDynamicAttributeStatus;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.DeleteDynamicAttribute;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.UpdateDynamicAttribute;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllAttributeOperations;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllAttributeTablesNames;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDataTypes;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Helpers.UpdateDynamicAttributeValue;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DynamicAttributeController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public DynamicAttributeController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("CreateNewDynamicAttribute")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> 
            CreateNewDynamicAttribute([FromBody] CreateDynamicAttributeCommand CreateDynamicAttributeCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            CreateDynamicAttributeCommand.lang = !string.IsNullOrEmpty(HeaderValue) 
                ? HeaderValue
                : "en";

            BaseResponse<CreateDynamicAttributeResponse>? Response = await _Mediator.Send(CreateDynamicAttributeCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("UpdateDynamicAttribute")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateDynamicAttribute([FromBody] UpdateDynamicAttributeCommand UpdateDynamicAttributeCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateDynamicAttributeCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(UpdateDynamicAttributeCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteDynamicAttribute/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteDynamicAttribute(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteDynamicAttributeCommand()
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
        [HttpGet("GetAllDynamicAttribute")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllDynamicAttribute(int SectionId, int Page = 1, int PerPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<DynamicAttributeListVM>> Response = await _Mediator.Send(new GetAllDynamicAttributesBySectionIdQuery()
            {
                SectionId = SectionId,
                lang = HeaderValue!,
                page = Page,
                pageSize = PerPage
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetDynamicAttributeById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetDynamicAttributeById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetDynamicAttributeByIdDto> Response = await _Mediator.Send(new GetDynamicAttributeByIdQuery()
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
        [HttpPatch("ChangeDynamicAttributeStatus/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ChangeDynamicAttributeStatus(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new ChangeDynamicAttributeStatusCommand()
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
        [HttpGet("GetAllAttributeTablesNames")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAttributeTablesNames()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllAttributeTablesNamesListVM>> Response = await _Mediator.Send(new GetAllAttributeTablesNamesQuery()
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
        [HttpGet("GetAllDataTypes")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllDataTypes()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllDataTypesListVM>> Response = await _Mediator.Send(new GetAllDataTypesQuery()
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
        [HttpGet("GetAllAttributeOperations")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAttributeOperations()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllAttributeOperationsListVM>> Response = await _Mediator.Send(new GetAllAttributeOperationsQuery()
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
        [HttpPost("AddDynamicAttributeValue")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            AddDynamicAttributeValue([FromBody] AddDynamicAttributeValueCommand AddDynamicAttributeValueCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            AddDynamicAttributeValueCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<AddDynamicAttributeValueResponse>? Response = await _Mediator.Send(AddDynamicAttributeValueCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("UpdateDynamicAttributeValue")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            UpdateDynamicAttributeValue([FromBody] UpdateDynamicAttributeValueCommand UpdateDynamicAttributeValueCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateDynamicAttributeValueCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<UpdateDynamicAttributeValueResponse>? Response = await _Mediator.Send(UpdateDynamicAttributeValueCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
