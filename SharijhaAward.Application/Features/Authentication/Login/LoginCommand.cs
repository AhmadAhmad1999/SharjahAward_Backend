using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Authentication.Login
{
    public class LoginCommand : IRequest<AuthenticationResponse>
    {
        public string Email { get; set; }=string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
