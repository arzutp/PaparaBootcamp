using AutoMapper;
using Microsoft.Extensions.Caching.Distributed;
using PaparaHomework.Redis.Models.DTOs;
using PaparaHomework.Redis.Shared;
using System.Text.Json;
using static StackExchange.Redis.Role;

namespace PaparaHomework.Redis.Models.Products
{
    public class ProductService : IProductService
    {
        IProductRepository productRepository;
        IDistributedCache _distributedCache;
        IMapper _mapper;

        public ProductService(IDistributedCache distributedCache, IProductRepository productRepository, IMapper mapper)
        {
            _distributedCache = distributedCache;
            this.productRepository = productRepository;
            _mapper = mapper;
        }

        public ResponseDto<List<ProductDto>> GetAll()
        {
            var hasDistributedCacheProduct = _distributedCache.GetString("products");

            if (hasDistributedCacheProduct != null)
            {
                var productListWithDtoWithDistributedCache =
                    JsonSerializer.Deserialize<List<ProductDto>>(hasDistributedCacheProduct);
                return ResponseDto<List<ProductDto>>.Success(productListWithDtoWithDistributedCache!);
            }

            var prodcuctListSerializerString = JsonSerializer.Serialize(productRepository.GetAll());


            _distributedCache.SetString("products", prodcuctListSerializerString, new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1)
            });


           // var productList = productRepository.GetAll();

            var productListWithDto = _mapper.Map<List<ProductDto>>(prodcuctListSerializerString);

            return ResponseDto<List<ProductDto>>.Success(productListWithDto);
        }
    }
}
