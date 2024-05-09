using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.ResendEmail;
using IronBarCode;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http.Headers;
using SharijhaAward.Api.Logger;

namespace SharijhaAward.Api.Controllers
{
    // [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class ResendEmailController : ControllerBase
    {
        private readonly IMediator _Mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public ResendEmailController(IMediator mediator, IWebHostEnvironment WebHostEnvironment)
        {
            _Mediator = mediator;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpGet("ResendEmail", Name = "ResendEmail")]
        public async Task<ActionResult<int>> ResendEmail( int InviteeId, string type)
        {
            var headerValue = HttpContext.Request.Headers["lang"];
            var response = await _Mediator.Send(new ResendEmailQuery()
            {
                InviteeId= InviteeId, 
                Type = type,
                lang = headerValue,
                ImagePath = _WebHostEnvironment.WebRootPath
            });

            return Ok(new { data = response });
        }
    }
}
