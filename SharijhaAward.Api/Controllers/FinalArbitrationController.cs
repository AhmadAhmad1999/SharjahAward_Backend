using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.ChangeFinalArbitrationStatus;
using SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.CreateChairmanNotesOnFinalArbitrationScore;
using SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.CreateFinalArbitrationScore;
using SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.DeleteChairmanNotesOnFinalArbitrationScore;
using SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.UpdateChairmanNotesOnFinalArbitrationScore;
using SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetAllFormsForFinalArbitration;
using SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetFinalArbitrationById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class FinalArbitrationController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public FinalArbitrationController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }

        [HttpPost("CreateChairmanNotesOnFinalArbitrationScore")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateChairmanNotesOnFinalArbitrationScore([FromBody] CreateChairmanNotesOnFinalArbitrationScoreCommand CreateChairmanNotesOnFinalArbitrationScoreCommand)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateChairmanNotesOnFinalArbitrationScoreCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            CreateChairmanNotesOnFinalArbitrationScoreCommand.Token = Token;

            BaseResponse<object>? Response = await _Mediator.Send(CreateChairmanNotesOnFinalArbitrationScoreCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("CreateFinalArbitrationScore")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateFinalArbitrationScore([FromBody] CreateFinalArbitrationScoreCommand CreateFinalArbitrationScoreCommand)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateFinalArbitrationScoreCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            CreateFinalArbitrationScoreCommand.Token = Token;

            BaseResponse<object>? Response = await _Mediator.Send(CreateFinalArbitrationScoreCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteChairmanNotesOnFinalArbitrationScore/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteChairmanNotesOnFinalArbitrationScore(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteChairmanNotesOnFinalArbitrationScoreCommand()
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
        [HttpPut("UpdateChairmanNotesOnFinalArbitrationScore")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateChairmanNotesOnFinalArbitrationScore([FromBody] UpdateChairmanNotesOnFinalArbitrationScoreCommand UpdateChairmanNotesOnFinalArbitrationScoreCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateChairmanNotesOnFinalArbitrationScoreCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(UpdateChairmanNotesOnFinalArbitrationScoreCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllFormsForFinalArbitration")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllFormsForFinalArbitration(ArbitrationType? ArbitrationType, bool? AsChairman,
            string? SubscriberName, bool asSubcommitteeOfficer, bool asNormalArbitrator, bool asChairmanOfCommittees, 
            bool AsFullAccess, bool asExpert, bool asQuality, int Page = 1, int PerPage = 10)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetAllFormsForFinalArbitrationMainListVM> Response = await _Mediator.Send(new GetAllFormsForFinalArbitrationQuery()
            {
                lang = HeaderValue!,
                page = Page,
                perPage = PerPage,
                Token = Token,
                ArbitrationType = ArbitrationType,
                AsChairman = AsChairman,
                AsFullAccess = AsFullAccess,
                SubscriberName = SubscriberName,
                asSubcommitteeOfficer = asSubcommitteeOfficer,
                asNormalArbitrator = asNormalArbitrator,
                asChairmanOfCommittees = asChairmanOfCommittees,
                asExpert = asExpert,
                asQuality = asQuality
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetFinalArbitrationByFormId/{FormId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetFinalArbitrationByFormId(int FormId)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetFinalArbitrationByIdMainDto> Response = await _Mediator.Send(new GetFinalArbitrationByIdQuery()
            {
                lang = HeaderValue!,
                FormId = FormId,
                Token = Token
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("ChangeFinalArbitrationStatus")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ChangeArbitrationStatus([FromBody] ChangeFinalArbitrationStatusCommand ChangeFinalArbitrationStatusCommand)
        {
            string Token = HttpContext.Request.Headers.Authorization!;

            ChangeFinalArbitrationStatusCommand.Token = Token;

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            ChangeFinalArbitrationStatusCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(ChangeFinalArbitrationStatusCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
