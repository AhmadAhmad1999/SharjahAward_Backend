using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.DynamicAttributePatterns.Commands.SelectPatternAsDynamicAttribute;
using SharijhaAward.Application.Features.DynamicAttributePatterns.Queries.GetAllDynamicAttributePattern;
using SharijhaAward.Application.Features.DynamicAttributePatterns.Queries.GetDynamicAttributePatternById;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DynamicAttributePatternController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public DynamicAttributePatternController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("SelectPatternAsDynamicAttribute")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            SelectPatternAsDynamicAttribute([FromBody] SelectPatternAsDynamicAttributeCommand SelectPatternAsDynamicAttributeCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            SelectPatternAsDynamicAttributeCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<SelectPatternAsDynamicAttributeResponse>? Response = await _Mediator.Send(SelectPatternAsDynamicAttributeCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllDynamicAttributePattern")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllDynamicAttributePattern(int Page = 1, int PerPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllDynamicAttributePatternListVM>> Response = await _Mediator.Send(new GetAllDynamicAttributePatternQuery()
            {
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
        [HttpGet("GetDynamicAttributePatternById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetDynamicAttributePatternById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetDynamicAttributePatternByIdDto> Response = await _Mediator.Send(new GetDynamicAttributePatternByIdQuery()
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
