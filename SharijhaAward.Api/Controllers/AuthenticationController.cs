using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Authentication.Login;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public AuthenticationController(IMediator mediator)
        {
            _Mediator = mediator;
        }
        //
        [HttpPost("Login", Name = "Login")]
        public async Task<ActionResult<string>> Login([FromBody] string email, [FromBody] string password)
        {
          string token= await  _Mediator.Send(new LoginCommand() { Email = email, Password = password });
            
            return Ok(token);
        }
    }
}
