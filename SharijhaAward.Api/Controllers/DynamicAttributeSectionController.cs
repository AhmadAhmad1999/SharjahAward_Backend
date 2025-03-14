﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.DeleteDynamicAttributeSection;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.ReorderDynamicAttributesInsideTheSections;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.UpdateDynamicAttributeSection;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForView;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetDynamicAttributeSectionById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Api.Logger;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAddForUser;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class DynamicAttributeSectionController : ControllerBase
    {
        private readonly IMediator _Mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public DynamicAttributeSectionController(IMediator Mediator,
            IWebHostEnvironment _WebHostEnvironment)
        {
            _Mediator = Mediator;
            this._WebHostEnvironment = _WebHostEnvironment;
        }
        [HttpPost("CreateNewDynamicAttributeSection")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> 
            CreateNewDynamicAttributeSection([FromBody] CreateDynamicAttributeSectionCommand CreateDynamicAttributeSectionCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            CreateDynamicAttributeSectionCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<CreateDynamicAttributeSectionResponse>? Response = await _Mediator.Send(CreateDynamicAttributeSectionCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("UpdateDynamicAttributeSection")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateDynamicAttributeSection([FromBody] UpdateDynamicAttributeSectionCommand UpdateDynamicAttributeSectionCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateDynamicAttributeSectionCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            UpdateDynamicAttributeSectionCommand.lang = HeaderValue!;

            BaseResponse<object> Response = await _Mediator.Send(UpdateDynamicAttributeSectionCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteDynamicAttributeSection/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteDynamicAttributeSection(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteDynamicAttributeSectionCommand()
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
        [HttpGet("GetAllDynamicAttributeSectionsForView")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllDynamicAttributeSectionsForView(int? CategoryId,
            bool? isArbitrator, int EventId, InviteeTypes? InviteeType, int? RoleId, int Page = 1, int PerPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<DynamicAttributeSectionListVM>> Response = await _Mediator.Send(new GetAllDynamicAttributeSectionsForViewQuery()
            {
                CategoryId = CategoryId,
                isArbitrator = isArbitrator != null ? isArbitrator.Value : false,
                lang = HeaderValue!,
                page = Page,
                perPage = PerPage,
                WWWRootFilePath = _WebHostEnvironment.WebRootPath,
                EventId = EventId,
                InviteeType = InviteeType,
                RoleId = RoleId
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetDynamicAttributeSectionById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetDynamicAttributeSectionById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetDynamicAttributeSectionByIdDto> Response = await _Mediator.Send(new GetDynamicAttributeSectionByIdQuery()
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
        [HttpGet("GetAllDynamicAttributeSectionsForAdd")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllDynamicAttributeSectionsForAdd(int? ProvidedFormId,
            int? ArbitratorId, int? CoordinatorId, bool? isArbitrator, int? EventId, InviteeTypes? InviteeType,
            int? GroupInviteeId, int? PersonalInviteeId, int? PersonalInviteeNumber, int? GroupInviteeNumber)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>> Response = await _Mediator.Send(new GetAllDynamicAttributeSectionsForAddQuery()
            {
                lang = HeaderValue!,
                ProvidedFormId = ProvidedFormId,
                ArbitratorId = ArbitratorId,
                CoordinatorId = CoordinatorId,
                isArbitrator = isArbitrator,
                EventId = EventId,
                InviteeType = InviteeType,
                GroupInviteeId = GroupInviteeId,
                PersonalInviteeId = PersonalInviteeId,
                PersonalInviteeNumber = PersonalInviteeNumber,
                GroupInviteeNumber = GroupInviteeNumber
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("ReorderDynamicAttributesInsideTheSections")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            ReorderDynamicAttributesInsideTheSections([FromBody] ReorderDynamicAttributesInsideTheSectionsCommand ReorderDynamicAttributesInsideTheSectionsCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            ReorderDynamicAttributesInsideTheSectionsCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(ReorderDynamicAttributesInsideTheSectionsCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllDynamicAttributeSectionsForAddForUser")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllDynamicAttributeSectionsForAddForUser(int UserId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<RolesListVM>> Response = await _Mediator.Send(new GetAllDynamicAttributeSectionsForAddForUserQuery()
            {
                lang = HeaderValue!,
                UserId = UserId
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
