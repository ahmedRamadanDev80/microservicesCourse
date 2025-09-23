using Micro.Services.AuthAPI.Models;
using Micro.Services.AuthAPI.Models.Dtos;
using Micro.Services.AuthAPI.Services.IService;

namespace Micro.Services.AuthAPI.Services
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        public string GenerateToken(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }

    }
}
