using Micro.Services.EmailAPI.Models.Dtos;

namespace Micro.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
    }
}
