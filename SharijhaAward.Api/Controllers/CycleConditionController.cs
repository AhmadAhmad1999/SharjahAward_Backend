﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.CycleConditions.Attachments.Queries.AcceptOnAttachments;
using SharijhaAward.Application.Features.CycleConditions.Commands.CreateCycleCondition;
using SharijhaAward.Application.Features.CycleConditions.Commands.DeleteCycleCondition;
using SharijhaAward.Application.Features.CycleConditions.Commands.UpdateCycleCondition;
using SharijhaAward.Application.Features.CycleConditions.Queries.AgreeOnCycleCondition;
using SharijhaAward.Application.Features.CycleConditions.Queries.CheckAllCycleConditions;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetAllCycleConditions;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionByCycleId;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionById;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.CycleConditions.Attachments.Queries.ReviewCycleConditionAttachments;
using SharijhaAward.Application.Features.CycleConditions.Queries.ExportToExcel;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class CycleConditionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CycleConditionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "AddCycleCondition")]
        public async Task<ActionResult> AddCycleCondition(CreateCycleConditionCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            command.lang = language!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };

        }
        [HttpPut(Name = "UpdateCycleCondition")]
        public async Task<ActionResult> UpdateCycleCondition(UpdateCycleConditionCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            command.lang = language!;
            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };

        }
        [HttpDelete("{Id}",Name = "DeleteCycleCondition")]
        public async Task<ActionResult> DeleteCycleCondition(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteCycleConditionCommand()
            {
                Id = Id,
                lang = language!
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("{Id}", Name = "GetCycleConditionById")]
        public async Task<ActionResult> GetCycleConditionById(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetCycleConditionByIdQuery()
            {
                Id = Id,
                lang = language!
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet(Name = "GetAllCycleCondition")]
        public async Task<ActionResult> GetAllCycleCondition([FromQuery] GetAllCycleConditionsQuery query)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            query.lang = language!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                400 => NotFound(response),
                _ => BadRequest(response)
            };

        }
        [HttpGet("GetCycleConditionByFormId", Name = "GetCycleConditionByFormId")]
        public async Task<ActionResult> GetCycleConditionByFormId([FromQuery] int formId)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            var response = await _mediator.Send(new GetCycleConditionByFormIdQuery()
            {

                formId = formId,
                token = token!,
                lang = language!
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }
        [HttpPost("AgreeOnCycleCondition", Name = "AgreeOnCycleCondition")]
        public async Task<IActionResult> AgreeOnCycleCondition(AgreeOnCycleConditionQuery query)
        {
            var token = HttpContext.Request.Headers.Authorization;

            query.token = token!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("CheckAllCycleConditions", Name = "CheckAllCycleConditions")]
        public async Task<IActionResult> CheckAllCycleConditions(int formId)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new CheckAllCycleConditionsQuery()
            {
                formId = formId,
                lang = Language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("ReviewCycleConditionAttachments", Name = "ReviewCycleConditionAttachments")]
        public async Task<ActionResult> ReviewCycleConditionAttachments([FromQuery] int formId)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            var response = await _mediator.Send(new ReviewCycleConditionAttachmentsQuery()
            {
                formId = formId,
                token = token!,
                lang = language!
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpPut("AcceptOnAttachments", Name= "AcceptOnAttachments")]
        public async Task<IActionResult> AcceptOnAttachments(AcceptOnAttachmentsQuery query)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            query.lang = language;
            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("CycleConditionExportToExcel", Name = "CycleConditionExportToExcel")]
        public async Task<IActionResult> CycleConditionExportToExcel()
        {
            var response = await _mediator.Send(new ExportToExcelQuery());

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "CycleConditions.xlsx"),
                _ => BadRequest(response)
            };
        }
    }
}
