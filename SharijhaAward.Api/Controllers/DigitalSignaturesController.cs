using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.DigitalSignatureFeatures.Commands.CreateDigitalSignature;
using SharijhaAward.Application.Features.DigitalSignatureFeatures.Commands.DeleteDigitalSignature;
using SharijhaAward.Application.Features.DigitalSignatureFeatures.Commands.UpdateDigitalSignature;
using SharijhaAward.Application.Features.DigitalSignatureFeatures.Queries.GetAllDigitalSignaturesForUser;
using SharijhaAward.Application.Features.DigitalSignatureFeatures.Queries.GetDigitalSignatureById;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class DigitalSignaturesController : ControllerBase
    {
        private readonly IMediator _Mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public DigitalSignaturesController(IMediator Mediator,
            IWebHostEnvironment _WebHostEnvironment)
        {
            _Mediator = Mediator;
            this._WebHostEnvironment = _WebHostEnvironment;
        }
        [HttpPost("CreateDigitalSignature")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateDigitalSignature([FromForm] CreateDigitalSignatureCommand CreateDigitalSignatureCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateDigitalSignatureCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
            : "en";

            CreateDigitalSignatureCommand.Token = HttpContext.Request.Headers.Authorization;

            CreateDigitalSignatureCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "/DigitalSignatures/";

            BaseResponse<object>? Response = await _Mediator.Send(CreateDigitalSignatureCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteDigitalSignature/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteDigitalSignature(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteDigitalSignatureCommand()
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
        [HttpPut("UpdateDigitalSignature")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateDigitalSignature([FromForm] UpdateDigitalSignatureCommand UpdateDigitalSignatureCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateDigitalSignatureCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            UpdateDigitalSignatureCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "/DigitalSignatures";

            BaseResponse<object>? Response = await _Mediator.Send(UpdateDigitalSignatureCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllDigitalSignaturesForUser")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllDigitalSignaturesForUser([FromQuery] GetAllDigitalSignaturesForUserQuery GetAllDigitalSignaturesForUserQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllDigitalSignaturesForUserQuery.lang = HeaderValue!;
            GetAllDigitalSignaturesForUserQuery.Token = HttpContext.Request.Headers.Authorization;

            BaseResponse<List<GetAllDigitalSignaturesForUserListVM>> Response = await _Mediator.Send(GetAllDigitalSignaturesForUserQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetDigitalSignatureById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetDigitalSignatureById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetDigitalSignatureByIdDto> Response = await _Mediator.Send(new GetDigitalSignatureByIdQuery()
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
