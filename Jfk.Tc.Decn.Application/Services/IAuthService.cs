using Jfk.Tc.Decn.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jfk.Tc.Decn.Application.Services
{
    public interface IAuthService
    {
        Task<bool> ValidateCredentials(LoginDto loginDto);

        TokenOutDto GenerateJwtToken(LoginDto loginDto);
    }
}