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
        [HttpGet("ResendEmail", Name = "ResendEmail")]
        public async Task<ActionResult<Guid>> ResendEmail( Guid InviteeId, string type)
        {
            var headerValue = HttpContext.Request.Headers["lang"];
            var response = await _Mediator.Send(new ResendEmailQuery()
            {
                InviteeId= InviteeId, 
                Type = type,
                lang = headerValue
            });
            return Ok(new { data = response });
        }

    }
}
