using Micro.Services.AuthAPI.Models.Dtos;

namespace Micro.Services.AuthAPI.Services.IService
{
    public interface IAuthService
    {
        Task<UserDto> Register(RegistrationRequestDto registrationRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
    }
}
