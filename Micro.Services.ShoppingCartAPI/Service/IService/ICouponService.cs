using Micro.Services.ShoppingCartAPI.Models.Dtos;

namespace Micro.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
