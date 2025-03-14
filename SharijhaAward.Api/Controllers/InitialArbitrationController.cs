﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllFormsForSortingProcess;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.ChangeArbitrationStatus;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.CreateChairmanNotesOnInitialArbitration;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.CreateInitialArbitration;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.DeleteChairmanNotesOnInitialArbitration;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.UpdateChairmanNotesOnInitialArbitration;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetAllFromsForInitialArbitration;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class InitialArbitrationController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public InitialArbitrationController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("CreateChairmanNotesOnInitialArbitration")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateChairmanNotesOnInitialArbitration([FromBody] CreateChairmanNotesOnInitialArbitrationCommand CreateChairmanNotesOnInitialArbitrationCommand)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateChairmanNotesOnInitialArbitrationCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            CreateChairmanNotesOnInitialArbitrationCommand.Token = Token;

            BaseResponse<object>? Response = await _Mediator.Send(CreateChairmanNotesOnInitialArbitrationCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("CreateInitialArbitration")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateInitialArbitration([FromBody] CreateInitialArbitrationCommand CreateInitialArbitrationCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateInitialArbitrationCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(CreateInitialArbitrationCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteChairmanNotesOnInitialArbitration/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteChairmanNotesOnInitialArbitration(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteChairmanNotesOnInitialArbitrationCommand()
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
        [HttpPut("UpdateChairmanNotesOnInitialArbitration")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateChairmanNotesOnInitialArbitration([FromBody] UpdateChairmanNotesOnInitialArbitrationCommand UpdateChairmanNotesOnInitialArbitrationCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateChairmanNotesOnInitialArbitrationCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(UpdateChairmanNotesOnInitialArbitrationCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllFromsForInitialArbitration")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllFromsForInitialArbitration([FromQuery] GetAllFromsForInitialArbitrationQuery GetAllFromsForInitialArbitrationQuery)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllFromsForInitialArbitrationQuery.Token = Token;
            GetAllFromsForInitialArbitrationQuery.lang = HeaderValue;

            BaseResponse<GetAllFromsForInitialArbitrationFullResponse> Response = await _Mediator.Send(GetAllFromsForInitialArbitrationQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetInitialArbitrationByArbitrationId/{ArbitrationId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetInitialArbitrationByArbitrationId(int ArbitrationId, bool asExpert,
            bool asChairmanOfCommittees, bool asQuality, bool asChairman, bool AsFullAccess, bool asNormalArbitrator, bool asSubcommitteeOfficer)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetInitialArbitrationByArbitrationIdResponse> Response = await _Mediator.Send(new GetInitialArbitrationByArbitrationIdQuery()
            {
                lang = HeaderValue!,
                ArbitrationId = ArbitrationId,
                Token = Token,
                asExpert = asExpert,
                asChairmanOfCommittees = asChairmanOfCommittees,
                asQuality = asQuality,
                asChairman = asChairman,
                AsFullAccess = AsFullAccess,
                asNormalArbitrator = asNormalArbitrator,
                asSubcommitteeOfficer = asSubcommitteeOfficer
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("ChangeArbitrationStatus")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ChangeArbitrationStatus([FromBody] ChangeArbitrationStatusMainCommand ChangeArbitrationStatusMainCommand)
        {
            string Token = HttpContext.Request.Headers.Authorization!;

            ChangeArbitrationStatusMainCommand.Token = Token;

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            ChangeArbitrationStatusMainCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(ChangeArbitrationStatusMainCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
