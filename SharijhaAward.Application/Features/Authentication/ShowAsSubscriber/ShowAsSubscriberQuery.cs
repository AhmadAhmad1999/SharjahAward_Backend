using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Authentication.ShowAsSubscriber
{
    public class ShowAsSubscriberQuery : IRequest<AuthenticationResponse>
    {
        public int UserId { get; set; }
        public string token { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
