﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.TermsAndConditions.Attacments.Commands.CreateAttachment;
using SharijhaAward.Application.Features.TermsAndConditions.Attacments.Commands.DeleteAttachment;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConditionAttachmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ConditionAttachmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name="AddAttachment")]
        public async Task<IActionResult> AddAttachment(CreateAttachmentCommand command)
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
        [HttpDelete(Name="DeleteAttachment")]
        public async Task<IActionResult> DeleteAttachment(Guid Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteAttachmentCommand()
            {
                AttachmentId = Id,
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
