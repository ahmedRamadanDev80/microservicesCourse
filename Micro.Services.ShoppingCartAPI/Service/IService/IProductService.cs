using Micro.Services.ShoppingCartAPI.Models.Dtos;

namespace Micro.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
