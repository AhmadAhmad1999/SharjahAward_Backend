using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.ContactUsPages.Commands.CreateMessage;
using SharijhaAward.Application.Features.ContactUsPages.Commands.DeleteMessage;
using SharijhaAward.Application.Features.ContactUsPages.Queries.ClosingEmailMessage;
using SharijhaAward.Application.Features.ContactUsPages.Queries.ForwordEmail;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllMsgForAwardTeam;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetEmailMessageById;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetMsgByIdForAwardTeam;
using SharijhaAward.Api.Logger;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactUsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "SendMessage")]
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
        [HttpGet(Name = "GetAllMessages")]
        public async Task<IActionResult> GetAllMessages(string? query, int? filter, int page = 1, int perPage = 10)
        {
            var token = HttpContext.Request.Headers.Authorization;

            var Language = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(token))
                return Language == "en"
                    ? Unauthorized("Un Authorize")
                    : Unauthorized("إنتهت صلاحية الجلسة");

            var response = await _mediator.Send(new GetAllEmailMessageQuery()
            {
                filter = filter,
                page = page,
                perPage = perPage,
                query = query,
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
        
        [HttpDelete("{Id}", Name= "DeleteMessage")]
        public async Task<IActionResult> DeleteMessage(int Id)
        {
            var Language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;
            if (string.IsNullOrEmpty(token))
                return Language == "en"
                    ? Unauthorized("Un Authorize")
                    : Unauthorized("إنتهت صلاحية الجلسة");

           

            var response = await _mediator.Send(new DeleteMessageCommand()
            {
                Id = Id,
                lang = Language!,
            });

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                401 => Unauthorized(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("{Id}", Name = "GetMessageById")]
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

        [HttpGet("GetMessageByIdForAwardTeam/{Id}", Name = "GetMessageByIdForAwardTeam")]
        public async Task<IActionResult> GetMessageByIdForAwardTeam(int Id)
        {
            var token = HttpContext.Request.Headers.Authorization;

            var Language = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(token))
                return Language == "en"
                    ? Unauthorized("Un Authorize")
                    : Unauthorized("إنتهت صلاحية الجلسة");

            var response = await _mediator.Send(new GetMsgByIdForAwardTeamQuery()
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

        [HttpGet("GetAllMessagesForAwardTeam", Name = "GetAllMessagesForAwardTeam")]
        public async Task<IActionResult> GetAllMessagesForAwardTeam(bool FromWebsite, int page = 1, int perPage = 10)
        {
            var token = HttpContext.Request.Headers.Authorization;

            var Language = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(token))
                return Language == "en"
                    ? Unauthorized("Un Authorize")
                    : Unauthorized("إنتهت صلاحية الجلسة");

            var response = await _mediator.Send(new GetAllMsgForAwardTeamQuery()
            {
                token = token!,
                page = page,
                perPage = perPage,
                lang = Language!,
                FromWebsite = FromWebsite
            });
            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                401 => Unauthorized(response),
                _ => BadRequest(response)
            };
        }

        [HttpPost("ForwordEmail", Name = "ForwordEmail")]
        public async Task<IActionResult> ForwordEmail([FromBody] ForwordEmailQuery query)
        {
            var token = HttpContext.Request.Headers.Authorization;
            var language = HttpContext.Request.Headers["lang"];

            query.token = token!;
            query.lang = language!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                401 => Unauthorized(response),
                _ => BadRequest(response)
            };
        }

        [HttpPut("ClosingEmailMessage/{Id}", Name = "ClosingEmailMessage")]
        public async Task<IActionResult> ClosingEmailMessage(int Id)
        {
            var token = HttpContext.Request.Headers.Authorization;

            var Language = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(token))
                return Language == "en"
                    ? Unauthorized("Un Authorize")
                    : Unauthorized("إنتهت صلاحية الجلسة");

            var response = await _mediator.Send(new ClosingEmailMessageQuery()
            {
                token = token!,
                Id = Id,
                lang = Language!
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
