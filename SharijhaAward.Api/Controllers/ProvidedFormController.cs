﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.ProvidedForm.Command.CreateProvidedForm;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidedFormController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProvidedFormController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateProvidedForm")]
        public async Task<IActionResult> CreateProvidedForm(CreateProvidedFormCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            command.token = token!;
            command.lang = Language!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }
    }
}
