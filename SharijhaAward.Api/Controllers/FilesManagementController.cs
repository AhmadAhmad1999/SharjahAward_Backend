﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.FilesManagementFeatures.Queries.DownloadFilesByIds;
using SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetAllFilesByFilter;
using SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetFilePathById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.FilesManagementFeatures.Queries.ExportToExcel;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class FilesManagementController : ControllerBase
    {
        private readonly IMediator _Mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public FilesManagementController(IMediator Mediator,
            IWebHostEnvironment WebHostEnvironment)
        {
            _Mediator = Mediator;
            _WebHostEnvironment = WebHostEnvironment;
        }

        [HttpGet("GetAllFilesByFilter")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllFilesByFilter([FromQuery] GetAllFilesByFilterQuery GetAllFilesByFilterQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllFilesByFilterQuery.lang = HeaderValue;

            GetAllFilesByFilterQuery.wwwRootFilePath = _WebHostEnvironment.WebRootPath;

            BaseResponse<List<GetAllFilesByFilterListVM>> Response = await _Mediator.Send(GetAllFilesByFilterQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetFilePathById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetFilePathById(int Id, int? RowId, int FilterId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetFilePathByIdDto> Response = await _Mediator.Send(new GetFilePathByIdQuery()
            {
                Id = Id,
                FilterId = FilterId,
                lang = HeaderValue!,
                RowId = RowId
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("DownloadFilesByIds")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DownloadFilesByIds([FromQuery] List<int> Ids, [FromQuery] List<int> TableAttributeIds, [FromQuery] int FilterId, [FromQuery]bool DownloadAllFiles)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<DownloadFilesByIdsListVM>> Response =
                await _Mediator.Send(new DownloadFilesByIdsQuery()
                {
                    Ids = Ids,
                    lang = HeaderValue,
                    FilterId = FilterId,
                    DownloadAllFiles = DownloadAllFiles,
                    TableAttributeIds = TableAttributeIds
                });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("FilesExportToExcel")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> FilesExportToExcel(int FilterId)
        {
            BaseResponse<byte[]> Response = await _Mediator.Send(new FilesExportToExcelQuery()
            {
                FilterId = FilterId
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => File(Response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Files.xlsx"),
                _ => BadRequest(Response)
            };
        }
    }
}
