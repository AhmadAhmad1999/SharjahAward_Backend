﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Circulars.Command.DeleteCircular;
using SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars;
using SharijhaAward.Application.Features.HomePageSliderItems.Commands.CreateHomePageSliderItem;
using SharijhaAward.Application.Features.HomePageSliderItems.Commands.DeleteHomePageSliderItem;
using SharijhaAward.Application.Features.HomePageSliderItems.Queries.GetAllHomePageSliderItems;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.HomePageSliderItems.Commands.UpdateHomePageSliderItem;

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
        public async Task<IActionResult> GetAllHomeSliderItems(int page = 1, int perPage = 10)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllHomePageSliderItemsQuery()
            {
                page = page,
                perPage = perPage,
                lang = language!
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
