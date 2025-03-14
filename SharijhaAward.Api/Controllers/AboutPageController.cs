﻿using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.AboutAwardPages.Commands.CreateAboutPage;
using SharijhaAward.Application.Features.AboutAwardPages.Commands.CreateGoal;
using SharijhaAward.Application.Features.AboutAwardPages.Commands.DeleteGoal;
using SharijhaAward.Application.Features.AboutAwardPages.Commands.UpdateAboutPage;
using SharijhaAward.Application.Features.AboutAwardPages.Commands.UpdateGoal;
using SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPage;
using SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPageWebSite;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class AboutPageController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly HttpClient _HttpClient;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public AboutPageController(IMediator mediator,
            HttpClient _HttpClient,
            IWebHostEnvironment _WebHostEnvironment)
        {
            _mediator = mediator;
            this._HttpClient = _HttpClient;
            this._WebHostEnvironment = _WebHostEnvironment;
        }
        [HttpPost(Name = "CreateAboutPage")]
        public async Task<IActionResult> CreateAboutPage([FromForm] CreateAboutPageCommand command)
        {
            //get Language from header
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
        [HttpPost("CreateGoal", Name = "CreateGoal")]
        public async Task<IActionResult> CreateGoal([FromBody] CreateGoalCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }
        [HttpGet(Name = "GetAboutAwardPage")]
        public async Task<IActionResult> GetAboutAwardPage()
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAboutPageQuery()
            {
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("GetAboutPageWebSite", Name = "GetAboutPageWebSite")]
        public async Task<IActionResult> GetAboutPageWebSite()
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAboutPageWebSiteQuery()
            {
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPut(Name = "UpdateAboutPage")]
        public async Task<IActionResult> UpdateAboutPage([FromForm] UpdateAboutPageCommand command)
        {
            //get Language from header
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
        [HttpPut("UpdateGoal", Name = "UpdateGoal")]
        public async Task<IActionResult> UpdateGoal(UpdateGoalCommand command)
        {
            //get Language from header
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
        [HttpDelete("DeleteGoal/{Id}", Name = "DeleteGoal")]
        public async Task<IActionResult> DeleteGoal(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteGoalCommand()
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
