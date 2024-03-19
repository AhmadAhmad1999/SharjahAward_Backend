﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.GeneralWorkshops.Commands.CreateGeneralWorkshop;
using SharijhaAward.Application.Features.GeneralWorkshops.Queries.GetAllGeneralWorkshops;
using SharijhaAward.Application.Features.GeneralWorkshops.Queries.GetGeneralWorkshopById;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralWorkshopeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GeneralWorkshopeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost(Name = "CreateGeneralWorkshope")]
        public async Task<IActionResult> CreateGeneralWorkshope([FromForm] CreateGeneralWorkshopCommand command)
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
        [HttpGet(Name = "GetAllGeneralWorkshope")]
        public async Task<IActionResult> GetAllGeneralWorkshope(int page = 1, int pageSize = 10)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllGeneralWorkshopsQuery()
            {
                lang = language!,
                page = page,
                pageSize = pageSize
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("{Id}",Name= "GetGeneralWorkshopById")]
        public async Task<IActionResult> GetGeneralWorkshopById(Guid Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetGeneralWorkshopByIdQuery()
            {
                Id = Id,
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
