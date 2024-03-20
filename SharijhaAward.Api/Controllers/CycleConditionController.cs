using Aspose.Pdf.Operators;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.CycleConditions.Commands.CreateCycleCondition;
using SharijhaAward.Application.Features.CycleConditions.Commands.DeleteCycleCondition;
using SharijhaAward.Application.Features.CycleConditions.Commands.UpdateCycleCondition;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetAllCycleConditions;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionByCycleId;
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
        [HttpPut(Name="UpdateCycleCondition")]
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
        [HttpDelete(Name = "DeleteCycleCondition")]
        public async Task<ActionResult> DeleteCycleCondition(Guid Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteCycleConditionCommand()
            {
                Id = Id,
                lang =language!
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

        [HttpGet(Name="GetAllCycleCondition")] 
        public async Task<ActionResult> GetAllCycleCondition(int page = 1, int perPage = 10)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllCycleConditionsQuery()
            {
                lang = language!,
                page = page,
                pageSize = perPage
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                400 => NotFound(response),
                _ => BadRequest(response)
            };

        }
        [HttpGet("GetCycleConditionByCycleId/{CycleId}", Name = "GetCycleConditionByCycleId")]
        public async Task<ActionResult> GetCycleConditionByCycleId(Guid CycleId)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetCycleConditionByCycleIdQuery()
            {
                CycleId = CycleId,
                lang = language!
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }
    }
}
