using Jfk.Tc.Decn.Application.Dtos;
using Jfk.Tc.Decn.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text;

namespace Jfk.Tc.Decn.Api.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            bool credentialsAreValid = await _authService.ValidateCredentials(loginDto);
            if (!credentialsAreValid)
            {
                return Unauthorized("Credenciales no válidas");
            }

            TokenOutDto token = _authService.GenerateJwtToken(loginDto);

            return Ok(new
            {
                token = token.Token,
                expires = token.Expires
            });
        }
    }
}