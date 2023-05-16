using Dhaba.Services.ProductAPI.Models.Dto;

namespace Dhaba.Services.ProductAPI.Repository
{
    public interface IProductRespositroy
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
