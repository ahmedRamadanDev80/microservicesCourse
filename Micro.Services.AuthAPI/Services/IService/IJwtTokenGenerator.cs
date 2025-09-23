using Micro.Services.AuthAPI.Models;
using Micro.Services.AuthAPI.Models.Dtos;

namespace Micro.Services.AuthAPI.Services.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
