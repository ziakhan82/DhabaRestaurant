using AutoMapper;
using Dhaba.Services.ProductAPI.Models;
using Dhaba.Services.ProductAPI.Models.Dto;

namespace Dhaba.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;

        }
    }
}
