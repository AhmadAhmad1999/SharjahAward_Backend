using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.ContactUsPages.Commands.CreateMessage;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetEmailMessageById;
using SharijhaAward.Application.Responses;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactUsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name="SendMessage")]
        public async Task<IActionResult> SendMessage([FromForm] CreateMessageCommand command)
        {
            var token = HttpContext.Request.Headers.Authorization;
            var language = HttpContext.Request.Headers["lang"];

            command.token = token!;
            command.lang = language!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                401 => Unauthorized(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet(Name="GetAllMessages")]
        public async Task<IActionResult> GetAllMessages()
        {
            var token = HttpContext.Request.Headers.Authorization;

            var Language = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(token))
                return Language == "en"
                    ? Unauthorized("Un Authorize")
                    : Unauthorized("إنتهت صلاحية الجلسة");

            var response = await _mediator.Send(new GetAllEmailMessageQuery()
            {
                lang = Language!,
                token = token!
            });
            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                401 => Unauthorized(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("{Id}",Name="GetMessageById")]
        public async Task<IActionResult> GetMessageById(int Id)
        {
            var token = HttpContext.Request.Headers.Authorization;

            var Language = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(token))
                return Language == "en"
                    ? Unauthorized("Un Authorize")
                    : Unauthorized("إنتهت صلاحية الجلسة");

            var response = await _mediator.Send(new GetEmailMessageByIdQuery()
            {
                Id = Id,
                lang = Language!,
                token = token!
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                401 => Unauthorized(response),
                _ => BadRequest(response)
            };
        }
    }
}
