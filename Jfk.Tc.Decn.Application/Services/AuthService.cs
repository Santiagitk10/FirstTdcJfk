using Jfk.Tc.Decn.Application.Dtos;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Jfk.Tc.Decn.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> ValidateCredentials(LoginDto loginDto)
        {
            bool isValid = false;
            if (loginDto.Usuario == _configuration["Jwt:usuario"] &&
                loginDto.Contrasena == _configuration["Jwt:contrasena"])
            {
                isValid = true;
            }
            return isValid;
        }

        public TokenOutDto GenerateJwtToken(LoginDto loginDto)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, loginDto.Usuario),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            DateTime expires = DateTime.Now.AddHours(12);
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: expires,
                signingCredentials: credentials
            );

            return new TokenOutDto { Token = new JwtSecurityTokenHandler().WriteToken(token), Expires = expires };
        }
    }
}