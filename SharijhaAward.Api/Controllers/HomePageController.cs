using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.HomePageFeatures.Queries.GetAllHomePageData;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class HomePageController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public HomePageController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }

        [HttpGet("GetAllHomePageData")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllHomePageData(int? CycleId)
        {
            string Token = HttpContext.Request.Headers.Authorization!;

            if (Token.IsNullOrEmpty())
                return Unauthorized();

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetAllHomePageDataDto> Response = await _Mediator.Send(new GetAllHomePageDataQuery()
            {
                lang = HeaderValue!,
                Token = Token,
                CycleId = CycleId
            });

            return Response.statusCode switch
            {
                401 => Unauthorized(),
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
