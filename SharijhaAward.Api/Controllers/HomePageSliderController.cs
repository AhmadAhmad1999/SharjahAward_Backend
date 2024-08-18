using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Circulars.Command.DeleteCircular;
using SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars;
using SharijhaAward.Application.Features.HomePageSliderItems.Commands.CreateHomePageSliderItem;
using SharijhaAward.Application.Features.HomePageSliderItems.Commands.DeleteHomePageSliderItem;
using SharijhaAward.Application.Features.HomePageSliderItems.Queries.GetAllHomePageSliderItems;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.HomePageSliderItems.Commands.UpdateHomePageSliderItem;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Classes.Queries.GetClassById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Application.Features.HomePageSliderItems.Queries.GetHomePageSliderItemById;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    public class HomePageSliderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HomePageSliderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateHomeSliderItem")]
        public async Task<IActionResult> CreateHomeSliderItem([FromForm] CreateHomePageSliderItemCommand command)
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

        [HttpPut(Name = "UpdateHomePageSliderItem")]
        public async Task<IActionResult> UpdateHomePageSliderItem(UpdateHomePageSliderItemQuery query)
        {
            var language = HttpContext.Request.Headers["lang"];

            query.lang = language!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpDelete("{Id}", Name = "DeleteHomeSliderItem")]
        public async Task<IActionResult> DeleteHomeSliderItem(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteHomePageSliderItemCommand()
            {
                Id = Id,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet(Name = "GetAllHomeSliderItems")]
        public async Task<IActionResult> GetAllHomeSliderItems([FromQuery] GetAllHomePageSliderItemsQuery query)
        {
            var language = HttpContext.Request.Headers["lang"];
            
            query.lang = language!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("GetHomePageSliderItemById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetHomePageSliderItemById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetHomePageSliderItemByIdDto> Response = await _mediator.Send(new GetHomePageSliderItemByIdQuery()
            {
                Id = Id,
                lang = HeaderValue!
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
