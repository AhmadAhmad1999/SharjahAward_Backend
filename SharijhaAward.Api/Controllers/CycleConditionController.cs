﻿using Aspose.Pdf.Operators;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.CycleConditions.Commands.CreateCycleCondition;
using SharijhaAward.Application.Features.CycleConditions.Commands.DeleteCycleCondition;
using SharijhaAward.Application.Features.CycleConditions.Commands.UpdateCycleCondition;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetAllCycleConditions;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionById;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CycleConditionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CycleConditionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name ="AddCycleCondition")]
        public async Task<ActionResult> AddCycleCondition(CreateCycleConditionCommand command)
        {
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            command.lang = headerValue!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
           
        }
        [HttpPut(Name="UpdateCycleCondition")]
        public async Task<ActionResult> UpdateCycleCondition(UpdateCycleConditionCommand command)
        {
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            command.lang = headerValue!;
            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };

        }
        [HttpDelete(Name = "DeleteCycleCondition")]
        public async Task<ActionResult> DeleteCycleCondition(Guid Id)
        {
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            var response = await _mediator.Send(new DeleteCycleConditionCommand()
            {
                Id = Id,
                lang =headerValue!
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("{Id}", Name = "GetCycleConditionById")]
        public async Task<ActionResult> GetCycleConditionById(Guid Id)
        {
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            var response = await _mediator.Send(new GetCycleConditionByIdQuery()
            {
                Id = Id,
                lang = headerValue!
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet(Name="GetAllCycleCondition")] 
        public async Task<ActionResult> GetAllCycleCondition(int page, int perPage)
        {
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            perPage = perPage == 0 ? 10 : perPage;
            var response = await _mediator.Send(new GetAllCycleConditionsQuery()
            {
                lang = headerValue!,
                page = page,
                pageSize = perPage
            });

            return response.statusCode switch
            {
               
                200 => Ok(new
                {
                    response,
                    pagination =
                    new
                    {
                        current_page = page,
                        last_page = (int)Math.Ceiling((decimal)response.totalItem / perPage),
                        total_row = response.totalItem,
                        per_page = perPage,
                        currentPageCount = response.data!.Count
                    }
                }),
                _ => BadRequest(response)
            } ;

        }
    }
}
