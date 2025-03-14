﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.LoggerFeatures.Queries.GetHistoryByController;
using SharijhaAward.Application.Responses;
using SharijhaAward.Application.Features.LoggerFeatures.Queries.ExportToExcel;
using SharijhaAward.Api.Logger;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public HistoryController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }

        [HttpGet("GetHistoryByController")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetHistoryByController([FromQuery] GetHistoryByControllerQuery GetHistoryByControllerQuery)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetHistoryByControllerQuery.lang = HeaderValue;
            GetHistoryByControllerQuery.Token = Token;

            BaseResponse<List<GetHistoryByControllerListVM>> Response = await _Mediator.Send(GetHistoryByControllerQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("HistoryExportToExcel")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> HistoryExportToExcel()
        {
            BaseResponse<byte[]> Response = await _Mediator.Send(new ExportToExcelQuery());

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => File(Response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "History.xlsx"),
                _ => BadRequest(Response)
            };
        }
    }
}
