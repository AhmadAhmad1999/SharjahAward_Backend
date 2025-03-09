using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.ExtraAttachments.Attachment.Commands.AddExtraAttachmentFile;
using SharijhaAward.Application.Features.ExtraAttachments.Attachment.Commands.DeleteExtraAttachmentFile;
using SharijhaAward.Application.Features.ExtraAttachments.Attachment.Queries.AcceptOnExtraAttachmentFiles;
using SharijhaAward.Application.Features.ExtraAttachments.Commands.CreateExtraAttachment;
using SharijhaAward.Application.Features.ExtraAttachments.Commands.DeleteExtraAttachment;
using SharijhaAward.Application.Features.ExtraAttachments.Commands.UpdateExtraAttachment;
using SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachment;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.ExtraAttachments.Queries.CheckAllExtraAttachment;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.Classes.Commands.UpdateClass;
using SharijhaAward.Application.Responses;
using SharijhaAward.Application.Features.ExtraAttachments.Commands.AcceptRequestForExtraAttachment;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class ExtraAttachmentController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public ExtraAttachmentController(IMediator mediator)
        {
            _Mediator = mediator;
        }

        [HttpPost(Name = "CreateExtraAttachment")]
        public async Task<IActionResult> CreateExtraAttachment(CreateExtraAttachmentCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            command.lang = language!;

            var response = await _Mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }

        [HttpPut(Name = "UpdateExtraAttachment")]
        public async Task<IActionResult> UpdateExtraAttachment(UpdateExtraAttachmentCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            command.lang = language!;
            var response = await _Mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpDelete("{Id}", Name = "DeleteExtraAttachment")]
        public async Task<IActionResult> DeleteExtraAttachment(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _Mediator.Send(new DeleteExtraAttachmentCommand()
            {
                Id = Id,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("GetExtraAttachmentByFormId/{FormId}", Name="GetExtraAttachmentByFormId")]
        public async Task<IActionResult> GetExtraAttachmentByFormId(int FormId, bool GetOnlyTheRequests)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _Mediator.Send(new GetAllExtraAttachmentByFormIdQuery()
            {
                formId = FormId,
                lang = language!,
                GetOnlyTheRequests = GetOnlyTheRequests
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPost("AddExtraAttachmentFile",Name= "AddExtraAttachmentFile")]
        public async Task<IActionResult> AddExtraAttachmentFile([FromForm] AddExtraAttachmentFileCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            command.lang = language!;

            var response = await _Mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpDelete("DeleteExtraAttachmentFile/{FileId}",Name = "DeleteExtraAttachmentFile")]
        public async Task<IActionResult> DeleteExtraAttachmentFile(int FileId)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _Mediator.Send(new DeleteExtraAttachmentFileCommand()
            {
                FileId = FileId,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPut("AcceptOnExtraAttachmentFiles", Name = "AcceptOnExtraAttachmentFiles")]
        public async Task<IActionResult> AcceptOnExtraAttachmentFiles(AcceptOnExtraAttachmentFilesQuery query)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            query.lang = language;
            var response = await _Mediator.Send(query);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("CheckAllExtraAttachment", Name = "CheckAllExtraAttachment")]
        public async Task<IActionResult> CheckAllExtraAttachment(int formId)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            var response = await _Mediator.Send(new CheckAllExtraAttachmentQuery()
            {
                formId = formId,
                token = token!,
                lang = Language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPut("AcceptRequestForExtraAttachment")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> AcceptRequestForExtraAttachment(int ExtraAttachmentId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            BaseResponse<object>? Response = await _Mediator.Send(new AcceptRequestForExtraAttachmentCommand()
            {
                ExtraAttachmentId = ExtraAttachmentId,
                lang = !string.IsNullOrEmpty(HeaderValue)
                    ? HeaderValue
                    : "en"
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
