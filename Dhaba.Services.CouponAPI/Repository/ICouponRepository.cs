using Dhaba.Services.CouponAPI.Models.Dto;

namespace Dhaba.Services.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
    }
}
