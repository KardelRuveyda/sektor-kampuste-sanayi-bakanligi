using DotnetWorkshop.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetWorkshop.Service.Authorization.Abstract
{
    public interface IJwtAuthenticationManager
    {
        AuthResponseDto Authenticate(string userName, string password);
        int? ValidateJwtToken(string token);
    }
}
