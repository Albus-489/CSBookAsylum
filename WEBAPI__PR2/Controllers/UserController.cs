using BLL_Project2.DTO;
using BLL_Project2.DTO.Requests;
using BLL_Project2.DTO.Responses;
using BLL_Project2.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Project2.WEBAPI_PR2.JWTManager;
using System.Security.Claims;
using WEBAPI_Project2.Helpers;

namespace WEBAPI_Project2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IIdentityService identityService;
        private readonly IIdentity _identity;
        private IConfiguration _config;

        public UserController(IIdentityService identityService, IIdentity identity, IConfiguration config)
        {
            this.identityService = identityService;
            this._config = config;
            _identity = identity;

        }

        [HttpGet("Get")]
        public async Task<ActionResult<string>> GetCurrentUser()
        {
            return Ok("Simple GET");
        }

        [Authorize]
        [HttpGet("GetAuthorize")]
        public async Task<ActionResult<string>> GetCurrentUser1()
        {
            return Ok("Authorize GET");
        }

        [HttpPost("signIn")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AuthenticationDTO>> SignInAsync(
            [FromBody] UserSignInReq request)
        {
            try
            {
                var response = await _identity.SignInAsync(request);
                //SetRefreshTokenInCookie(response.RefreshToken);
                return Ok(response);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpPost("signUp")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AuthenticationDTO>> SignUpAsync(
            [FromBody] UserSignUpReq request)
        {
            try
            {
                var response = await _identity.SignUpAsync(request);
                return Ok(response);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        private void SetRefreshTokenInCookie(string refreshToken)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(10),
            };
            Response.Cookies.Append("refreshToken", refreshToken, cookieOptions);
        }

    }
}
