using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId;
using SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.AcceptRelatingRequest;
using SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.CancelRelating;
using SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.RejectRelatingRequest;
using SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.SendRelatingRequest;
using SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllReceivedRequests;
using SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllRelatedAccounts;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelatedAccountController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public RelatedAccountController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("AcceptRelatingRequest")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> AcceptRelatingRequest(int RelatingRequestId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object> Response = await _Mediator.Send(new AcceptRelatingRequestCommand()
            {
                Id = RelatingRequestId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("RejectRelatingRequest")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> RejectRelatingRequest(int RelatingRequestId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object> Response = await _Mediator.Send(new RejectRelatingRequestCommand()
            {
                Id = RelatingRequestId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("CancelRelating")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CancelRelating(int RelatingRequestId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object> Response = await _Mediator.Send(new CancelRelatingCommand()
            {
                Id = RelatingRequestId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("SendRelatingRequest")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> SendRelatingRequest(string ReceiverEmail)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            StringValues? Token = HttpContext.Request.Headers.Authorization;
            
            if (string.IsNullOrEmpty(Token))
                return BadRequest("You must send the token");

            BaseResponse<object> Response = await _Mediator.Send(new SendRelatingRequestCommand()
            {
                ReceiverEmail = ReceiverEmail,
                lang = HeaderValue!,
                token = Token
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllReceivedRequests")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllReceivedRequests(int Page = 1, int PerPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            StringValues? Token = HttpContext.Request.Headers.Authorization;
            
            if (string.IsNullOrEmpty(Token))
                return BadRequest("You must send the token");

            BaseResponse<List<GetAllReceivedRequestsListVM>> Response = await _Mediator.Send(new GetAllReceivedRequestsQuery()
            {
                lang = HeaderValue!,
                token = Token,
                page = Page,
                pageSize = PerPage
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllRelatedAccounts")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllRelatedAccounts(int Page = 1, int PerPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            StringValues? Token = HttpContext.Request.Headers.Authorization;
            
            if (string.IsNullOrEmpty(Token))
                return BadRequest("You must send the token");

            BaseResponse<List<GetAllRelatedAccountsListVM>> Response = await _Mediator.Send(new GetAllRelatedAccountsQuery()
            {
                lang = HeaderValue!,
                token = Token,
                page = Page,
                pageSize = PerPage
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
