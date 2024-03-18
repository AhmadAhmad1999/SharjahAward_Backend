using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.GeneralFAQCategories.Commands.CreateGeneralFAQCategory;
using SharijhaAward.Application.Features.GeneralFAQCategories.Commands.DeleteGeneralFAQCategory;
using SharijhaAward.Application.Features.GeneralFAQCategories.Commands.UpdateGeneralFAQCategory;
using SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetAllGeneralFAQCategory;
using SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetGeneralFAQCategoryById;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralFAQCategoryController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public GeneralFAQCategoryController(IMediator mediator)
        {
            _Mediator = mediator;
        }
        [HttpPost("CreateGeneralFAQCategory")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateGeneralFAQCategory([FromBody] CreateGeneralFAQCategoryCommand CreateGeneralFAQCategoryCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateGeneralFAQCategoryCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(CreateGeneralFAQCategoryCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("UpdateGeneralFAQCategory")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateGeneralFAQCategory([FromBody] UpdateGeneralFAQCategoryCommand UpdateGeneralFAQCategoryCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateGeneralFAQCategoryCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(UpdateGeneralFAQCategoryCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteGeneralFAQCategory")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteGeneralFAQCategory(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteGeneralFAQCategoryCommand()
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
        [HttpGet("GetGeneralFAQCategoryById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetGeneralFAQCategoryById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetGeneralFAQCategoryByIdDto> Response = await _Mediator.Send(new GetGeneralFAQCategoryByIdQuery()
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
        [HttpGet("GetAllGeneralFAQCategories")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllGeneralFAQCategories()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllGeneralFAQCategoryListVM>> Response = await _Mediator.Send(new GetAllGeneralFAQCategoryQuery()
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
    }
}
