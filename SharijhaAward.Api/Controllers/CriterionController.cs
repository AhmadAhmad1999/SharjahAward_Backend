using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.CriterionFeatures.Commands.CheckIfAllCritrionsHaveAttachment;
using SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterion;
using SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterionAttachment;
using SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterionItemAttachment;
using SharijhaAward.Application.Features.CriterionFeatures.Commands.DeleteCriterionAttachment;
using SharijhaAward.Application.Features.CriterionFeatures.Commands.DeleteCriterionItemAttachment;
using SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForView;
using SharijhaAward.Application.Features.TermsAndConditions.Attacments.Commands.CreateAttachment;
using SharijhaAward.Application.Features.TermsAndConditions.Attacments.Commands.DeleteAttachment;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CriterionController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public CriterionController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("CreateCriterion")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            CreateCriterion([FromBody] CreateCriterionCommand CreateCriterionCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            CreateCriterionCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<CreateCriterionResponse>? Response = await _Mediator.Send(CreateCriterionCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllCriterionByCategoryId")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllCriterionByCategoryId(Guid CategoryId, int ProvidedFormId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<MainCriterionListVM>> Response = await _Mediator.Send(new GetAllCriterionByCategoryIdQuery()
            {
                CategoryId = CategoryId,
                lang = HeaderValue!,
                ProvidedFormId = ProvidedFormId
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("CreateCriterionAttachment")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateCriterionAttachment([FromForm] CreateCriterionAttachmentCommand CreateCriterionAttachmentCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateCriterionAttachmentCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object> Response = await _Mediator.Send(CreateCriterionAttachmentCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("CreateCriterionItemAttachment")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateCriterionItemAttachment([FromForm] CreateCriterionItemAttachmentCommand CreateCriterionItemAttachmentCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateCriterionItemAttachmentCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object> Response = await _Mediator.Send(CreateCriterionItemAttachmentCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteCriterionAttachment")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteCriterionAttachment(Guid CriterionAttachmentId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            string? Language = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object> Response = await _Mediator.Send(new DeleteCriterionAttachmentCommand()
            {
                CriterionAttachmentId = CriterionAttachmentId,
                lang = Language!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteCriterionItemAttachment")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteCriterionItemAttachment(Guid CriterionItemAttachmentId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            string? Language = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object> Response = await _Mediator.Send(new DeleteCriterionItemAttachmentCommand()
            {
                CriterionItemAttachmentId = CriterionItemAttachmentId,
                lang = Language!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("CheckIfAllCritrionsHaveAttachment")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CheckIfAllCritrionsHaveAttachment([FromQuery] CheckIfAllCritrionsHaveAttachmentCommand CheckIfAllCritrionsHaveAttachmentCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            string? Language = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object> Response = await _Mediator.Send(CheckIfAllCritrionsHaveAttachmentCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
