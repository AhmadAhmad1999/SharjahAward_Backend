using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.SocialMediaPage.Commands.CreateSocialMediaItem;
using SharijhaAward.Application.Features.SocialMediaPage.Commands.DeleteSocialMediaItem;
using SharijhaAward.Application.Features.SocialMediaPage.Commands.UpdateSocialMediaItem;
using SharijhaAward.Application.Features.SocialMediaPage.Queries.GetAllSocialMediaItems;
using SharijhaAward.Application.Features.SocialMediaPage.Queries.GetSocialMediaItemById;
using SharijhaAward.Application.Features.StrategicPartners.Commands.CreateStrategicPartner;
using SharijhaAward.Application.Features.StrategicPartners.Commands.DeleteStrategicPartner;
using SharijhaAward.Application.Features.StrategicPartners.Commands.UpdateStrategicPartner;
using SharijhaAward.Application.Features.StrategicPartners.Queries.GetAllStrategicPartners;
using SharijhaAward.Application.Features.StrategicPartners.Queries.GetStrategicPartnerById;
using SharijhaAward.Api.Logger;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaItemController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SocialMediaItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateSocialMediaItem")]
        public async Task<IActionResult> CreateSocialMediaItem([FromForm] CreateSocialMediaItemCommand command)
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

        [HttpDelete("{Id}", Name = "DeleteSocialMediaItem")]
        public async Task<IActionResult> DeleteSocialMediaItem(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];



            var response = await _mediator.Send(new DeleteSocialMediaItemCommand()
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

        [HttpPut(Name = "UpdateSocialMediaItem")]
        public async Task<IActionResult> UpdateSocialMediaItem([FromForm] UpdateSocialMediaItemCommand command)
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

        [HttpGet(Name = "GetAllSocialMediaItem")]
        public async Task<IActionResult> GetAllSocialMediaItem(int page = 1, int perPage = 10)
        {

            var response = await _mediator.Send(new GetAllSocialMediaItemsQuery()
            {
                page = page,
                perPage = perPage
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("WebsiteGetAllSocialMediaItem", Name = "WebsiteGetAllSocialMediaItem")]
        public async Task<IActionResult> WebsiteGetAllSocialMediaItem(int page = 1, int perPage = 10)
        {

            var response = await _mediator.Send(new GetAllSocialMediaItemsQuery()
            {
                page = page,
                perPage = perPage
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("{Id}", Name = "GetSocialMediaItemById")]
        public async Task<IActionResult> GetSocialMediaItemById(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetSocialMediaItemByIdQuery()
            {
                lang = language!,
                Id = Id
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
