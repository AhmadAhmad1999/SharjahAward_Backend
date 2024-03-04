using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Domain.Entities.IdentityModels;
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
                new ("Id", user.Id.ToString()),
                new ("Email", user.Email.ToString())
            };

            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes("Security-Key854796olikujyh0213456")),
                SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
                (
                    _options.Issueer,
                    _options.Audience,
                    claims,
                    DateTime.UtcNow,
                    DateTime.UtcNow.AddDays(1),
                    signingCredentials
                );
            string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenValue;

        }
        public string GetUserIdFromToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = tokenHandler.ReadJwtToken(token);

            var userIdClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub)?.Value;
            return userIdClaim!;
        }
    }
    
}
