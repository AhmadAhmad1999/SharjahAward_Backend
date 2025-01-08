using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.ChatBotQuestions.Commands.CreateChatBotQuestion;
using SharijhaAward.Application.Features.ChatBotQuestions.Commands.DeleteChatBotQuestion;
using SharijhaAward.Application.Features.ChatBotQuestions.Commands.UpdateChatBotQuestion;
using SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetAllChatBotQuestions;
using SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetChatBotQuestionById;
using SharijhaAward.Application.Features.ChatBotQuestions.Queries.TalkWithChatBot;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class ChatBotController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public ChatBotController(IMediator mediator)
        {
            _Mediator = mediator;
        }

        [HttpPost(Name = "AddQuestion")]
        public async Task<IActionResult> AddAgenda(CreateChatBotQuestionCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            //command.lang = language!;

            var response = await _Mediator.Send(command);

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

            var response = await _Mediator.Send(new DeleteChatBotQuestionCommand()
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
        [HttpGet("GetAllChatBotQuestions")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllChatBotQuestions([FromQuery] GetAllChatBotQuestionsQuery GetAllChatBotQuestionsQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllChatBotQuestionsQuery.lang = HeaderValue;

            BaseResponse<List<ChatBotQuestionsListVM>> Response = await _Mediator.Send(GetAllChatBotQuestionsQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetChatBotQuestionById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetChatBotQuestionById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<ChatBotQuestionDto> Response = await _Mediator.Send(new GetChatBotQuestionByIdQuery()
            {
                Id = Id,
                lang = HeaderValue
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("TalkWithChatBot/{QuestionId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> TalkWithChatBot(int QuestionId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<ConversationDto> Response = await _Mediator.Send(new TalkWithChatBotQuery()
            {
                QuestionId = QuestionId,
                lang = HeaderValue
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("UpdateChatBotQuestion")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateChatBotQuestion([FromBody] UpdateChatBotQuestionCommand UpdateChatBotQuestionCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateChatBotQuestionCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(UpdateChatBotQuestionCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
