using SharijhaAward.Application.Features.Authentication.Login;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Responses
{
    public class AuthenticationResponse
    {
        public string token { get; set; } = string.Empty;
        public UserDataResponse user { get; set; } = null!;
        public List<Permission>? permissions { get; set; } = null!;
        public string message { get; set; } = string.Empty;
        public bool isSucceed { get; set; } = false;
    }
}
