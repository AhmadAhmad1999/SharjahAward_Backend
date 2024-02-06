using MediatR;
using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium.DevTools.V120.Browser;
using SharijhaAward.Application.Features.Authentication.Login;
using SharijhaAward.Application.Features.Authentication.SignUp;

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
        public async Task<ActionResult<string>> Login([FromBody] LoginCommand user)
        {
            var response = await _Mediator.Send(new LoginCommand() { Email = user.Email, Password = user.Password });

            return Ok(
                new 
                {
                    data = response.user,
                    key = response.token,
                    permission = response.permissions
                    
                });
        }
        [HttpPost("SignUp", Name = "SignUp")]
        public async Task<ActionResult<string>> SignUp([FromBody] SignUpCommand user)
        {
            string token = await _Mediator.Send(new SignUpCommand()
            {
                Email = user.Email,
                Password = user.Password,
                ArabicName = user.ArabicName,
                EnglishName = user.EnglishName,
                RoleName = user.RoleName,
                Gender = user.Gender
                
            });

            return Ok(new {data = token}) ;
        }
    }
}
