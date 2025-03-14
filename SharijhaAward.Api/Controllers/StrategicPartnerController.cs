﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
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
    public class StrategicPartnerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StrategicPartnerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateStrategicPartner")]
        public async Task<IActionResult> CreateStrategicPartner([FromForm] CreateStrategicPartnerCommand command)
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

        [HttpDelete("{Id}", Name = "DeleteStrategicPartner")]
        public async Task<IActionResult> DeleteStrategicPartner(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];



            var response = await _mediator.Send(new DeleteStrategicPartnerCommand()
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

        [HttpPut(Name = "UpdateStrategicPartner")]
        public async Task<IActionResult> UpdateStrategicPartner([FromForm] UpdateStrategicPartnerCommand command)
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

        [HttpGet(Name = "GetAllStrategicPartners")]
        public async Task<IActionResult> GetAllStrategicPartners([FromQuery] GetAllStrategicPartnersQuery query)
        {

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        
        [HttpGet("{Id}", Name = "GetStrategicPartnerById")]
        public async Task<IActionResult> GetStrategicPartnerById(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetStrategicPartnerByIdQuery()
            {
              lang =language!,
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
