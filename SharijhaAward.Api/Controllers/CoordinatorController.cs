﻿using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinator;
using SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinatorEducationalEntity;
using SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinatorInstitution;
using SharijhaAward.Application.Features.Coordinators.Commands.DeleteCoordinator;
using SharijhaAward.Application.Features.Coordinators.Commands.UpdateCoordinator;
using SharijhaAward.Application.Features.Coordinators.Queries.AddCordinatorToEduEntity;
using SharijhaAward.Application.Features.Coordinators.Queries.GetAllCoordinators;
using SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById;
using SharijhaAward.Application.Features.Coordinators.Queries.SearchForCoordinator;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.DeleteDynamicAttribute;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatorController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public CoordinatorController(IMediator mediator,
            IWebHostEnvironment WebHostEnvironment)
        {
            _mediator = mediator;
            _WebHostEnvironment = WebHostEnvironment;
        }

        [HttpPost(Name = "CreateCoordinator")]
        public async Task<IActionResult> CreateCoordinator([FromForm] CreateCoordinatorCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            command.lang = Language!;

            command.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "\\DynamicFiles\\";

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("{CoordinatorId}" ,Name="GetCoordinatorById")]
        public async Task<IActionResult> GetCoordinatorById(Guid CoordinatorId)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetCoordinatorByIdQuery()
            {
                CoordinatorId = CoordinatorId,
                lang = Language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("SearchForCoordinators",Name = "SearchForCoordinators")]
        public async Task<IActionResult> SearchForCoordinators([FromQuery] SearchForCoordinatorQuery query)
        {
            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPost("AddCoordinatorToEduEntity",Name = "AddCoordinatorToEduEntity")]
        public async Task<IActionResult> AddCoordinatorToEduEntity(AddCoordinatorToEduEntityQuery query)
        {
            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPut("UpdateCoordinator")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateCoordinator([FromBody] UpdateCoordinatorCommand UpdateCoordinatorCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateCoordinatorCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            UpdateCoordinatorCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "\\DynamicFiles\\";

            BaseResponse<object>? Response = await _mediator.Send(UpdateCoordinatorCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteCoordinator/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteCoordinator(Guid Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _mediator.Send(new DeleteCoordinatorCommand()
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
        [HttpGet("GetAllCoordinators")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllCoordinators(int Page = 1, int PerPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllCoordinatorsListVM>> Response = await _mediator.Send(new GetAllCoordinatorsQuery()
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
        [HttpPost("CreateCoordinatorEducationalEntity")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateCoordinatorEducationalEntity(CreateCoordinatorEducationalEntityCommand CreateCoordinatorEducationalEntityCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateCoordinatorEducationalEntityCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _mediator.Send(CreateCoordinatorEducationalEntityCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("CreateCoordinatorInstitution")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateCoordinatorInstitution(CreateCoordinatorInstitutionCommand CreateCoordinatorInstitutionCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateCoordinatorInstitutionCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _mediator.Send(CreateCoordinatorInstitutionCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
