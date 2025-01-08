using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.AdvancedFormBuilderPatterns.Commands.SelectPatternAsAdvancedFormBuilder;
using SharijhaAward.Application.Features.AdvancedFormBuilderPatterns.Queries.GetAdvancedFormBuilderPatternById;
using SharijhaAward.Application.Features.AdvancedFormBuilderPatterns.Queries.GetAllAdvancedFormBuilderPattern;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class AdvancedFormBuilderPatternsController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public AdvancedFormBuilderPatternsController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("SelectPatternAsAdvancedFormBuilder")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            SelectPatternAsAdvancedFormBuilder([FromBody] SelectPatternAsAdvancedFormBuilderCommand SelectPatternAsAdvancedFormBuilderCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            SelectPatternAsAdvancedFormBuilderCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(SelectPatternAsAdvancedFormBuilderCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllAdvancedFormBuilderPattern")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAdvancedFormBuilderPattern(int Page = 1, int PerPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllAdvancedFormBuilderPatternListVM>> Response = await _Mediator.Send(new GetAllAdvancedFormBuilderPatternQuery()
            {
                lang = HeaderValue!,
                page = Page,
                perPage = PerPage
            });
            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAdvancedFormBuilderPatternById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAdvancedFormBuilderPatternById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetAdvancedFormBuilderPatternByIdDto> Response = await _Mediator.Send(new GetAdvancedFormBuilderPatternByIdQuery()
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
