using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Authentication
{
    public class AuthenticationResponse
    {
        public string token {  get; set; }=string.Empty;
        public Domain.Entities.IdentityModels.User user { get; set; } = null!;
        public List<Permission>? permissions { get; set; } = null!;
    }
}
