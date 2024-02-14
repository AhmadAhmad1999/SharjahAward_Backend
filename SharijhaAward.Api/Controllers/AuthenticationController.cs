using MediatR;
using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium.DevTools.V120.Browser;
using SharijhaAward.Application.Features.Authentication;
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<string>> Login([FromBody] LoginCommand user)
        {
            var response = await _Mediator.Send(
                new LoginCommand()
                { 
                    Email = user.Email,
                    Password = user.Password 
                });
            if (response.user == null)
            {
                return StatusCode(400,
                    new
                    {
                        message = response.message
                    });
            }
            else 
                return Ok(
                    new
                    {
                        data = response.user,
                        key = response.token,
                        permission = response.permissions,
                        message = response.message

                    });
        }
        [HttpPost("SignUp", Name = "SignUp")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<string>> SignUp([FromBody] SignUpCommand user)
        {
            var response = await _Mediator.Send(new SignUpCommand()
            {
                Email = user.Email,
                Password = user.Password,
                ArabicName = user.ArabicName,
                EnglishName = user.EnglishName,
                RoleName = user.RoleName,
                Gender = user.Gender
                
            });

            if (response.user == null)
            {
                return StatusCode(400,
                    new
                    {
                        message = response.message
                    });
            }
            else
                return Ok(
                    new
                    {
                        data = response.user,
                        key = response.token,
                        permission = response.permissions,
                        message = response.message

                    });
        }
    }
}
