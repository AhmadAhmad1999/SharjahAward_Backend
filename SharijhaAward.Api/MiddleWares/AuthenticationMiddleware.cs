using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Infrastructure.Authentication;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;

namespace SharijhaAward.Api.MiddleWares
{
    
    public class AuthenticationMiddleware 
    {
        private readonly RequestDelegate _next;
        private readonly ServiceProvider _serviceProvider;
        

        public AuthenticationMiddleware( RequestDelegate next, ServiceProvider serviceProvider)
        {
            _next = next;
            _serviceProvider = serviceProvider;

        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Skip token validation for specific paths
            if (context.Request.Path.StartsWithSegments("/api/Authentication/Login") ||
                context.Request.Path.StartsWithSegments("/api/Authentication/SignUp"))
            {
                await _next(context);
                return;
            }

            
            var authorizationHeader = context.Request.Headers.Authorization.ToString();

            if (string.IsNullOrEmpty(authorizationHeader))
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                await context.Response.WriteAsync("Invalid token.");
                return;
            }

            var token = authorizationHeader.Replace("Bearer ", "");


            if (string.IsNullOrEmpty(token))
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                await context.Response.WriteAsync("Token is missing.");
                return;
            }

            try
            {
                var UserId = _serviceProvider.GetService<IJwtProvider>().GetUserIdFromToken(token);

                var UserToken = _serviceProvider.GetService<IAsyncRepository<UserToken>>()
                    .Where(u => u.UserId == int.Parse(UserId) && u.Token == token)
                    .FirstOrDefault();

                if(UserToken == null)
                {
                    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    await context.Response.WriteAsync("Invalid token.");
                    return;
                }

            }
            catch
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                await context.Response.WriteAsync("Invalid token.");
                return;
            }

            await _next(context);

        }
    }
}
