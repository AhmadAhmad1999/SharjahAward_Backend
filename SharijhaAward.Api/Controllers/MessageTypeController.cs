using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.MessageTypes.Commands.CreateMsgType;
using SharijhaAward.Application.Features.MessageTypes.Commands.DeleteMsgType;
using SharijhaAward.Application.Features.MessageTypes.Commands.UpdateMsgType;
using SharijhaAward.Application.Features.MessageTypes.Queries.AsignMessageToRole;
using SharijhaAward.Application.Features.MessageTypes.Queries.GetAllMsgType;
using SharijhaAward.Api.Logger;

namespace SharijhaAward.Api.Controllers
{
    // [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class MessageTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MessageTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateMessageType")]
        public async Task<IActionResult> CreateMessageType(CreateMsgTypeCommand command)
        {
            var language = HttpContext.Request.Headers["lang"];

            command.lang = language!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response),
            };
        }

        [HttpDelete("{Id}", Name = "DeleteMessageType")]
        public async Task<IActionResult> DeleteMessageType(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteMsgTypeCommand()
            {
                Id = Id,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response),
            };

        }

        [HttpPut(Name = "UpdateMessageType")]
        public async Task<IActionResult> UpdateMessageType(UpdateMsgTypeCommand command)
        {
            var language = HttpContext.Request.Headers["lang"];

            command.lang = language!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response),
            };
        }

        [HttpGet(Name="GetAllMessageType")]
        public async Task<IActionResult> GetAllMessageType()
        {
            var response = await _mediator.Send(new GetAllMsgQuery());

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response),
            };
        }

        [HttpPost("AsignMessageTypeToRole",Name = "AsignMessageTypeToRole")]
        public async Task<IActionResult> AsignMessageTypeToRole(AsignMessageToRoleQuery query)
        {
            var language = HttpContext.Request.Headers["lang"];

            query.lang = language!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response),
            };
        }
    }
}
