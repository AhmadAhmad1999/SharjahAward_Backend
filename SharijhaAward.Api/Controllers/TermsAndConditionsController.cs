using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.TermsAndConditions.Commands.CreateTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Commands.DeleteTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Commands.UpdateTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.AgreeOnTermsAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.CheckAllConditions;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllSpecialConditionsByCategoryId;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetTermAndConditionById;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
        public async Task<IActionResult> GetAllTermsAndConditions([FromQuery] Guid? CategoryId, int page = 1 , int perPage = 10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
         

            var response = await _mediator.Send(new GetAllTermAndConditionQuery()
            {
                page = page,
                pageSize =  perPage ,
                lang = Language!,
                CategoryId = CategoryId
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("GetAllTermsAndConditionsByCategoryId/{Id}", Name = "GetAllTermsAndConditionsByCategoryId")]
        
        public async Task<IActionResult> GetAllTermsAndConditionsByCategoryId(Guid Id,[FromQuery]int formId)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
           // var token = HttpContext.Request.Headers.Authorization;
           
           
            var response = await _mediator.Send(new GetAllTermsByCategoryIdQuery()
            {
                lang = Language!,
                CategoryId = Id,
                formId = formId
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("GetAllSpecialConditionsByCategoryId/{Id}", Name = "GetAllSpecialConditionsByCategoryId")]
        public async Task<IActionResult> GetAllSpecialConditionsByCategoryId(Guid Id,int formId)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }
            var response = await _mediator.Send(new GetAllSpecialConditionsByCategoryIdQuery()
            {
                lang = Language!,
                CategoryId = Id,
                formId = formId,
                token = token!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpPost("AgreeOnTermAndCondition",Name ="AgreeOnTermAndCondition")]
        public async Task<IActionResult> AgreeOnTermAndCondition(AgreeOnTermsAndConditionQuery query)
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
        [HttpGet("CheckAllConditions/{Id}", Name= "CheckAllConditions")]
        public async Task<IActionResult> CheckAllConditions(Guid Id, int formId ,bool IsSpecial)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new CheckAllConditionsQuery()
            {
                CategoryId = Id,
                IsSpecial = IsSpecial,
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
    }
}
