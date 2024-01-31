using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.ResendEmail;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResendEmailController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public ResendEmailController(IMediator mediator)
        {
            _Mediator = mediator;
        }
        [HttpPost("ResendEmail", Name = "ResendEmail")]
        public async Task<ActionResult<Guid>> ResendEmail([FromBody] ResendEmailQuery ResendEmailQuery)
        {
            var headerValue = HttpContext.Request.Headers["lang"];
            if (!string.IsNullOrWhiteSpace(headerValue))
                ResendEmailQuery.lang = headerValue;

            var response = await _Mediator.Send(ResendEmailQuery);
            return Ok(new { data = response });
        }

    }
}
