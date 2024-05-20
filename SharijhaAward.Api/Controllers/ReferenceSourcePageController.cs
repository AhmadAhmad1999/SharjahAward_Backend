using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.ReferenceSources.Commands.UpdateReferenceSourcePage;
using SharijhaAward.Application.Features.ReferenceSources.Queries.GetReferenceSourcePage;
using SharijhaAward.Api.Logger;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class ReferenceSourcePageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReferenceSourcePageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut(Name= "UpdateReferenceSourcePage")]
        public async Task<IActionResult> UpdateReferenceSourcePage(UpdateReferenceSourcePageCommand command)
        {
            var language = HttpContext.Request.Headers["lang"];

            command.lang = language!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet(Name = "GetReferenceSourcePage")]
        public async Task<IActionResult> GetReferenceSourcePage()
        {
            var language = HttpContext.Request.Headers["lang"];


            var response = await _mediator.Send(new GetReferenceSourcePageQuery 
            {
                lang = language!,
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
