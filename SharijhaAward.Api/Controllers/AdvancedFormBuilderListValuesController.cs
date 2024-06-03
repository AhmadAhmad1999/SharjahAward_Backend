using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.AdvancedFormBuilderListValues.Commands.CreateAdvancedFormBuilderListValue;
using SharijhaAward.Application.Features.AdvancedFormBuilderListValues.Commands.DeleteAdvancedFormBuilderListValue;
using SharijhaAward.Application.Features.AdvancedFormBuilderListValues.Commands.UpdateAdvancedFormBuilderListValue;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvancedFormBuilderListValuesController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public AdvancedFormBuilderListValuesController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("CreateAdvancedFormBuilderListValue")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            CreateAdvancedFormBuilderListValue([FromBody] CreateAdvancedFormBuilderListValueCommand CreateAdvancedFormBuilderListValue)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            CreateAdvancedFormBuilderListValue.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(CreateAdvancedFormBuilderListValue);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("UpdateAdvancedFormBuilderListValue")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            UpdateAdvancedFormBuilderListValue([FromBody] UpdateAdvancedFormBuilderListValueCommand UpdateAdvancedFormBuilderListValue)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateAdvancedFormBuilderListValue.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(UpdateAdvancedFormBuilderListValue);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteAdvancedFormBuilderListValue/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteAdvancedFormBuilderListValue(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteAdvancedFormBuilderListValueCommand()
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
    }
}
