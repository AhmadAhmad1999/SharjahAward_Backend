﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.EducationalEntities.Command.CreateEducationalEntity;
using SharijhaAward.Application.Features.EducationalEntities.Command.DeleteEducationalEntity;
using SharijhaAward.Application.Features.EducationalEntities.Command.UpdateEducationalEntity;
using SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntities;
using SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntitiesForAdminDashboard;
using SharijhaAward.Application.Features.EducationalEntities.Queries.GetEducationalEntityById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.EducationalEntities.Queries.GetExcelFilePrototype;
using SharijhaAward.Application.Features.EducationalEntities.Queries.ImportDataFromExcel;


namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class EducationalEntityController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public EducationalEntityController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }

        [HttpPost("CreateEducationalEntity")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateEducationalEntity([FromBody] CreateEducationalEntityCommand CreateEducationalEntityCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateEducationalEntityCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<int>? Response = await _Mediator.Send(CreateEducationalEntityCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet(Name = "GetAllEducationalEntities")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllEducationalEntities(string? ArabicName, string? EnglishName)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            var response = await _Mediator.Send(new GetAllEducationalEntitiesCommand()
            {
                ArabicName = ArabicName,
                EnglishName = EnglishName,
                lang = HeaderValue
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpDelete("DeleteEducationalEntity/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteEducationalEntity(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteEducationalEntityCommand()
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
        [HttpPut("UpdateEducationalEntity")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateEducationalEntity([FromBody] UpdateEducationalEntityCommand UpdateEducationalEntityCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateEducationalEntityCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(UpdateEducationalEntityCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllEducationEntitiesForAdminDashboard")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllEducationEntitiesForAdminDashboard([FromQuery] GetAllEducationalEntitiesForAdminDashboardQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<GetAllEducationalEntitiesForAdminDashboardListVM>> Response = 
                await _Mediator.Send(query);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetEducationEntityById/{EducationEntityId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetEducationEntityById(int EducationEntityId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetEducationalEntityByIdDto> Response = await _Mediator.Send(new GetEducationalEntityByIdQuery()
            {
                EducationEntityId = EducationEntityId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpGet("GetExcelFilePrototypeForEducationalEntity", Name = "GetExcelFilePrototypeForEducationalEntity")]
        public async Task<IActionResult> GetExcelFilePrototype()
        {
            var response = await _Mediator.Send(new GetExcelFilePrototypeQuery());

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "EducationalEntityPrototype.xlsx"),
                _ => BadRequest(response)
            };
        }

        [HttpPost("ImportEducationalEntityFromExcel", Name = "ImportEducationalEntityFromExcel")]
        public async Task<IActionResult> ImportFromExcel([FromForm] ImportDataFromExcelQuery query)
        {
            var response = await _Mediator.Send(query);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                403 => StatusCode(response.statusCode, response),
                _ => BadRequest(response)
            };
        }
    }
}
