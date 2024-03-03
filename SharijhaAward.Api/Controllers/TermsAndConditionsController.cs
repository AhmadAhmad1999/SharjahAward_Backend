using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.TermsAndConditions.Commands.CreateTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Commands.DeleteTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Commands.UpdateTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetTermAndConditionById;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TermsAndConditionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TermsAndConditionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name= "AddTermAndCondition")]
        public async Task<IActionResult> AddTermAndCondition(CreateTermAndConditionCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
      
            command.lang = Language!;
            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };

        }
        [HttpDelete(Name = "DeleteTermAndCondition")]
        public async Task<IActionResult> DeleteTermAndCondition(Guid Id)
        {
             //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteTermAndConditionCommand()
            {
                Id = Id,
                lang= Language!,
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpPut(Name="UpdateTermAndCondition")]
        public async Task<IActionResult> UpdateTermAndCondition(UpdateTermAndConditionCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            command.lang= Language!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("{Id}",Name="GetTermAndCondition")]
        public async Task<IActionResult> GetTermAndCondition(Guid Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetTermAndConditionByIdQuery()
            {
                Id = Id,
                lang = Language!,
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet(Name="GetAllTermsAndConditions")]
        public async Task<IActionResult> GetAllTermsAndConditions(int page = 1 , int perPage = 10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
         

            var response = await _mediator.Send(new GetAllTermAndConditionQuery()
            {
                page = page,
                pageSize =  perPage ,
                lang = Language!,
            });

            return response.statusCode switch
            {
               
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }
    }
}
