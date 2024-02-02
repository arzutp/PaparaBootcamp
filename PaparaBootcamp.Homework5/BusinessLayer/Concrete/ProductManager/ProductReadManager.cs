using AutoMapper;
using BusinessLayer.Abstract.ProductServide;
using BusinessLayer.Constants;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.ProductRepository;
using EntityLayer.DTOs.ProductDTOs;
using EntityLayer.Entities;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ProductManager
{
    public class ProductReadManager(IProductReadRepository productReadRepository, IMapper mapper, IMemoryCache cache) : IProductReadService
    {
        private readonly IMapper _mapper = mapper;
        private readonly IProductReadRepository _productReadRepository = productReadRepository;
        IMemoryCache _cache = cache;

        public List<ProductGetAllDto> GetAll()
        {
            //if (_cache.TryGetValue("products", out List<ProductGetAllDto>? productListWithCache))
            //{
            //    return productListWithCache;
            //}
            //var productList = _productReadRepository.GetAll();
            //var productListWithDto = mapper.Map<List<ProductGetAllDto>>(productList);

            //_cache.Set("products", productListWithDto, TimeSpan.FromMinutes(1));

            var results = _productReadRepository.GetAll();
            var productGetAllDtos = _mapper.Map<List<ProductGetAllDto>>(results);
            return productGetAllDtos;
        }

        public List<ProductWithCategoryDto> GetAllProductsWithCategory()
        {
            return _productReadRepository.GetAllProductWithCategory();
        }

        public List<ProductWithDefinitionGetAllDto> GetAllProductWithDefinition(int id)
        {
            return _productReadRepository.GetAllProductWithDefinition(id);
        }

        public async Task<ResponseDto<ProductGetByIdDto>> GetById(int id)
        {
            var result = await _productReadRepository.GetByIdAsync(id);
            var productDto = _mapper.Map<ProductGetByIdDto>(result);
            if (productDto == null)
            {
                return ResponseDto<ProductGetByIdDto>.Fail(Messages.ProductInvalid);
            }
            return ResponseDto<ProductGetByIdDto>.Success(productDto);
        }
    }
}
