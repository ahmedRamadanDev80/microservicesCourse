using Micro.Services.OrderAPI.Models.Dtos;

namespace Micro.Services.OrderAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
