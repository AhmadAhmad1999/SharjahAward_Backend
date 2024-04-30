using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.FilesManagementFeatures.Queries.DownloadFilesByIds;
using SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetAllFilesByFilter;
using SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetFilePathById;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesManagementController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public FilesManagementController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }

        [HttpGet("GetAllFilesByFilter")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllFilesByFilter(GetAllFilesByFilterQuery GetAllFilesByFilterQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllFilesByFilterQuery.lang = HeaderValue;

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
        public async Task<IActionResult> GetFilePathById(int Id, FilesFilter Filter)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetFilePathByIdDto> Response = await _Mediator.Send(new GetFilePathByIdQuery()
            {
                Id = Id,
                Filter = Filter,
                lang = HeaderValue!
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
        public async Task<IActionResult> DownloadFilesByIds([FromQuery] List<int> Ids, FilesFilter Filter, bool DownloadAllFiles)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<DownloadFilesByIdsListVM>> Response =
                await _Mediator.Send(new DownloadFilesByIdsQuery()
                {
                    Ids = Ids,
                    lang = HeaderValue,
                    Filter = Filter,
                    DownloadAllFiles = DownloadAllFiles
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
