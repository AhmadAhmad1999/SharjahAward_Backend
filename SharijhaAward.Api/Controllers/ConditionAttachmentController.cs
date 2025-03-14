﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.CycleConditions.Attachments.Commands.CreateAttachment;
using SharijhaAward.Application.Features.TermsAndConditions.Attacments.Commands.CreateAttachment;
using SharijhaAward.Application.Features.TermsAndConditions.Attacments.Commands.DeleteAttachment;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.CycleConditions.Attachments.Commands.DeleteAttachment;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
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
        public async Task<IActionResult> AddAttachment([FromForm] CreateAttachmentCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;


            command.lang = language!;
            command.token = token!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpPost("AddAttachmentToCycleCondition",Name = "AddAttachmentToCycleCondition")]
        public async Task<IActionResult> AddAttachmentToCycleCondition([FromForm] CreateCycleConditionAttachmentCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            
            command.lang = language!;
            command.token = token!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpDelete(Name="DeleteAttachment")]
        public async Task<IActionResult> DeleteAttachment(int Id)
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
        
        [HttpDelete("DeleteCycleConditionAttachment", Name = "DeleteCycleConditionAttachment")]
        public async Task<IActionResult> DeleteCycleConditionAttachment(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteCycleConditionAttachmentCommand()
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
