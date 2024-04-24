using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.Classes.Commands.DeleteClass;
using SharijhaAward.Application.Features.Classes.Commands.UpdateClass;
using SharijhaAward.Application.Features.Classes.Queries.GetAllClasses;
using SharijhaAward.Application.Features.NotificationTemplateFeatures.Commands.CreateNotificationTemplate;
using SharijhaAward.Application.Features.NotificationTemplateFeatures.Commands.DeleteNotificationTemplate;
using SharijhaAward.Application.Features.NotificationTemplateFeatures.Commands.UpdateNotificationTemplate;
using SharijhaAward.Application.Features.NotificationTemplateFeatures.Queries.GetAllNotificationTemplates;
using SharijhaAward.Application.Features.NotificationTemplateFeatures.Queries.GetNotificationTemplateById;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationTemplatesController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public NotificationTemplatesController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("CreateNotificationTemplate")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateNotificationTemplate
            ([FromBody] CreateNotificationTemplateCommand CreateNotificationTemplateCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateNotificationTemplateCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(CreateNotificationTemplateCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteNotificationTemplate/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteNotificationTemplate(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteNotificationTemplateCommand()
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
        [HttpPut("UpdateNotificationTemplate")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateNotificationTemplate([FromBody] UpdateNotificationTemplateCommand UpdateNotificationTemplateCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateNotificationTemplateCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(UpdateNotificationTemplateCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllNotificationTemplates")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllNotificationTemplates(int Page = 1, int PerPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllNotificationTemplatesListVM>> Response = await _Mediator.Send(new GetAllNotificationTemplatesQuery()
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
        [HttpGet("GetNotificationTemplateById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetNotificationTemplateById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetNotificationTemplateByIdDto> Response = await _Mediator.Send(new GetNotificationTemplateByIdQuery()
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
