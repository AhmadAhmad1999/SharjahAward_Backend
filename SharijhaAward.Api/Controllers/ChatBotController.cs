using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Agendas.Commands.CreateAgenda;
using SharijhaAward.Application.Features.Agendas.Commands.DeleteAgenda;
using SharijhaAward.Application.Features.ChatBotQuestions.Commands.CreateChatBotQuestion;
using SharijhaAward.Application.Features.ChatBotQuestions.Commands.DeleteChatBotQuestion;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatBotController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ChatBotController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "AddQuestion")]
        public async Task<IActionResult> AddAgenda(CreateChatBotQuestionCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            //command.lang = language!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }

        [HttpDelete("{Id}", Name = "DeleteQuestion")]
        public async Task<IActionResult> DeleteQuestion(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteChatBotQuestionCommand()
            {
                Id = Id,
                
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
