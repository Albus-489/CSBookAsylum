
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc;

namespace Project2.WEBAPI_PR2.JWTManager
{
    public class JwtMiddleware
    {
        private readonly ILogger<JwtMiddleware> _logger;
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;

        public JwtMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task Invoke(HttpContext context, IUnitOfWork uow)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
                AttachUserToContext(context,uow, token);

            await _next(context);
        }

        public async void AttachUserToContext(HttpContext context, IUnitOfWork uow, string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                // min 16 characters
                var key = Encoding.ASCII.GetBytes(_configuration["Secret"]);
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = jwtToken.Claims.First(x => x.Type == "id").Value;

                context.Items["User"] = uow.UserManager.FindByIdAsync(userId);
            }
            catch (Exception e)
            {
                ///////
                // lgr
            }
        }
    }
}
