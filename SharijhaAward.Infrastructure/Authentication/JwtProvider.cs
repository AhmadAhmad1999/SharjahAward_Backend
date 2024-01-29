using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Domain.Model.IdentityModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SharijhaAward.Infrastructure.Authentication
{
    public class JwtProvider : IJwtProvider
    {
        private readonly JwtOptions _options;
        public JwtProvider(IOptions<JwtOptions> options)
        {
            _options = options.Value;
        }
        public string Generate(User user)
        {
            var claims = new Claim[]
            {
                new (JwtRegisteredClaimNames.Sub , user.Id.ToString()),
                new (JwtRegisteredClaimNames.Sub , user.Email.ToString())
            };

            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_options.SecurityKey)),
                SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
                (
                    _options.Issueer,
                    _options.Audience,
                    claims,
                    null,
                    DateTime.UtcNow.AddDays(1),
                    signingCredentials
                );
            string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenValue;

        }
    }
}
