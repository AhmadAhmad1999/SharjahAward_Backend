using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.CycleConditions.Attachments.Queries.AcceptOnAttachments;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionByCycleId;
using SharijhaAward.Application.Features.TermsAndConditions.Attacments.Queries.AcceptOnSpecialConditionAttachments;
using SharijhaAward.Application.Features.TermsAndConditions.Attacments.Queries.ReviewSpecialConditionAttachments;
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
using SharijhaAward.Api.Logger;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class TermsAndConditionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TermsAndConditionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "AddTermAndCondition")]
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
        [HttpDelete("{Id}", Name = "DeleteTermAndCondition")]
        public async Task<IActionResult> DeleteTermAndCondition(int Id)
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
        public async Task<IActionResult> GetTermAndCondition(int Id)
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
        public async Task<IActionResult> GetAllTermsAndConditions([FromQuery] int? CategoryId, int page = 1 , int perPage = 10)
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
        
        public async Task<IActionResult> GetAllTermsAndConditionsByCategoryId(int Id,[FromQuery]int formId)
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
        public async Task<IActionResult> GetAllSpecialConditionsByCategoryId(int Id,int formId)
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
        public async Task<IActionResult> CheckAllConditions(int Id, int formId )
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new CheckAllConditionsQuery()
            {
                CategoryId = Id,

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

        [HttpGet("ReviewSpecialConditionAttachments", Name = "ReviewSpecialConditionAttachments")]
        public async Task<ActionResult> ReviewSpecialConditionAttachments([FromQuery] int formId)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            var response = await _mediator.Send(new ReviewSpecialConditionAttachmentsQuery()
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

        [HttpPut("AcceptOnSpecialConditionAttachments", Name = "AcceptOnSpecialConditionAttachments")]
        public async Task<IActionResult> AcceptOnSpecialConditionAttachments(AcceptOnSpecialConditionAttachmentsQuery query)
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
    }
}
