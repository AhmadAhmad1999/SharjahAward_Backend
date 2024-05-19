using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.AddFinalScoreToArbitratoinForFormId;
using SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.RejectInitialArbiitrationFromArbitrationAudit;
using SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllFormsForArbitrationAudit;
using SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllInitialArbitrationOnForm;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class ArbitrationAuditController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public ArbitrationAuditController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("AddFinalScoreToArbitratoinForFormId")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> AddFinalScoreToArbitratoinForFormId([FromBody] AddFinalScoreToArbitratoinForFormIdCommand AddFinalScoreToArbitratoinForFormIdCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            AddFinalScoreToArbitratoinForFormIdCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(AddFinalScoreToArbitratoinForFormIdCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPatch("RejectInitialArbiitrationFromArbitrationAudit/{FormId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteClass(int FormId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new RejectInitialArbiitrationFromArbitrationAuditCommand()
            {
                FormId = FormId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllFormsForArbitrationAudit")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllFormsForArbitrationAudit([FromQuery] GetAllFormsForArbitrationAuditQuery GetAllFormsForArbitrationAuditQuery)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllFormsForArbitrationAuditQuery.lang = HeaderValue;
            GetAllFormsForArbitrationAuditQuery.Token = Token;

            BaseResponse<List<GetAllFormsForArbitrationAuditListVM>> Response = await _Mediator.Send(GetAllFormsForArbitrationAuditQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllInitialArbitrationOnForm/{FormId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllInitialArbitrationOnForm(int FormId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllInitialArbitrationOnFormListVM>> Response = await _Mediator.Send(new GetAllInitialArbitrationOnFormQuery()
            {
                FormId = FormId,
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
