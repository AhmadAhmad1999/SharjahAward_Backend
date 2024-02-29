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
        public async Task<ActionResult> AddTermAndCondition(CreateTermAndConditionCommand command)
        {
            //get Language from header
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
        [HttpDelete(Name = "DeleteTermAndCondition")]
        public async Task<ActionResult> DeleteTermAndCondition(Guid Id)
        {
            // get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            var response = await _mediator.Send(new DeleteTermAndConditionCommand()
            {
                Id = Id,
                lang= headerValue!,
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpPut(Name="UpdateTermAndCondition")]
        public async Task<ActionResult> UpdateTermAndCondition(UpdateTermAndConditionCommand command)
        {
            // get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            command.lang=headerValue!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("{Id}",Name="GetTermAndCondition")]
        public async Task<ActionResult> GetTermAndCondition(Guid Id)
        {
            // get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            var response = await _mediator.Send(new GetTermAndConditionByIdQuery()
            {
                Id = Id,
                lang = headerValue!,
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet(Name="GetAllTermsAndConditions")]
        public async Task<ActionResult> GetAllTermsAndConditions(int page , int perPage)
        {
            // get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";
            perPage = perPage == 0 ? 10 : perPage;

            var response = await _mediator.Send(new GetAllTermAndConditionQuery()
            {
                page = page,
                pageSize =  perPage ,
                lang = headerValue!,
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
            };
        }
    }
}
