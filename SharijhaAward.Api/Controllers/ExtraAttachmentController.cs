using Aspose.Html.Dom.Css;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Categories.Command.DeleteCategory;
using SharijhaAward.Application.Features.ExtraAttachments.Commands.CreateExtraAttachment;
using SharijhaAward.Application.Features.ExtraAttachments.Commands.DeleteExtraAttachment;
using SharijhaAward.Application.Features.ExtraAttachments.Commands.UpdateExtraAttachment;
using SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachment;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtraAttachmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExtraAttachmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateExtraAttachment")]
        public async Task<IActionResult> CreateExtraAttachment(CreateExtraAttachmentCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            command.lang = language!;

            var response = await _mediator.Send(command);

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
            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpDelete("{Id}", Name = "DeleteExtraAttachment")]
        public async Task<IActionResult> DeleteExtraAttachment(Guid Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteExtraAttachmentCommand()
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
        public async Task<IActionResult> GetExtraAttachmentByFormId(int FormId)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllExtraAttachmentByFormIdQuery()
            {
                formId = FormId,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
    }
}
