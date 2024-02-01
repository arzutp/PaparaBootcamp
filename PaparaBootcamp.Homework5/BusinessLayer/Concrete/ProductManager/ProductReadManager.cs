using AutoMapper;
using BusinessLayer.Abstract.ProductServide;
using BusinessLayer.Constants;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.ProductRepository;
using EntityLayer.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ProductManager
{
    public class ProductReadManager(IProductReadRepository productReadRepository, IMapper mapper) : IProductReadService
    {
        private readonly IMapper _mapper = mapper;
        private readonly IProductReadRepository _productReadRepository = productReadRepository;

        public List<ProductGetAllDto> GetAll()
        {
            var results = _productReadRepository.GetAll();
            var productGetAllDtos = _mapper.Map<List<ProductGetAllDto>>(results);
            return productGetAllDtos;
        }

        public async Task<ResponseDto<ProductGetByIdDto>> GetById(int id)
        {
            var result = await _productReadRepository.GetByIdAsync(id);
            var productDto = _mapper.Map<ProductGetByIdDto>(result);
            if(productDto == null)
            {
                return ResponseDto<ProductGetByIdDto>.Fail(Messages.ProductInvalid);
            }
            return ResponseDto<ProductGetByIdDto>.Success(productDto);
        }
    }
}
