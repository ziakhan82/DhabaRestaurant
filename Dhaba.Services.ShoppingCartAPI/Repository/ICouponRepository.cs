using Dhaba.Services.ShoppingCartAPI.Models.Dto;

namespace Dhaba.Services.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}
