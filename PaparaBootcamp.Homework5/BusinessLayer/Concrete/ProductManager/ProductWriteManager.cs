using AutoMapper;
using BusinessLayer.Abstract.ProductServide;
using BusinessLayer.Constants;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.ProductRepository;
using EntityLayer.DTOs.CategoryDTOs;
using EntityLayer.DTOs.ProductDTOs;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ProductManager
{
    public class ProductWriteManager(IProductWriteRepository productWriteRepository, IMapper mapper) : IProductWriteService
    {
        private readonly IMapper _mapper = mapper;
        private readonly IProductWriteRepository _productWriteRepository = productWriteRepository;

        public async Task<ResponseDto<ProductAddDto>> Add(ProductAddDto request)
        {
            var productDto = _mapper.Map<Product>(request);
            if(productDto == null )
            {
                return ResponseDto<ProductAddDto>.Fail(Messages.AddFailMessage);
            }
            await _productWriteRepository.AddAsync(productDto);
            return ResponseDto<ProductAddDto>.Success(request);
        }

        public void DeleteById(int id)
        {
            _productWriteRepository.Remove(id);
        }

        public void Update(ProductUpdateDto request)
        {
            var updateDto = _mapper.Map<Product>(request);
            _productWriteRepository.Update(updateDto);
        }
    }
}
