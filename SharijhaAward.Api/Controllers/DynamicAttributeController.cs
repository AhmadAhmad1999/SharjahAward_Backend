using Aspose.Html.Net;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Features.Event.Commands.CreateEvent;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DynamicAttributeController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public DynamicAttributeController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("CreateNewDynamicAttribute")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<CreateDynamicAttributeCommandResponse>> CreateNewDynamicAttribute([FromBody] CreateDynamicAttributeCommand CreateDynamicAttributeCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateDynamicAttributeCommandResponse? Response = await _Mediator.Send(CreateDynamicAttributeCommand);

            string ResponseMessage = !string.IsNullOrEmpty(HeaderValue)
                ? (HeaderValue.ToString() == "ar"
                    ? "تم إنشاء الفعالية بنجاح"
                    : "Dynamic Attribute Added Successfuly")
                : "تم إنشاء الفعالية بنجاح";

            return Ok(
                new
                {
                    data = Response,
                    message = ResponseMessage
                });
        }
    }
}
