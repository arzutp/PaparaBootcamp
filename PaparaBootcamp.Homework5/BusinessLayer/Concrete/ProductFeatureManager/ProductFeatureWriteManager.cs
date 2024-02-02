using AutoMapper;
using Azure.Core;
using BusinessLayer.Abstract.ProductDefinitionService;
using BusinessLayer.Abstract.ProductFeatureService;
using BusinessLayer.Constants;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.ProductDefinitionRepository;
using DataAccessLayer.Abstract.ProductFeatureRepository;
using EntityLayer.DTOs.ProductDefinitionDTOs;
using EntityLayer.DTOs.ProductFeatureDTOs;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ProductFeatureManager
{
    public class ProductFeatureWriteManager : IProductFeatureWriteService
    {
        private readonly IMapper _mapper;
        private readonly IProductFeatureWriteRepository _productFeatureWriteRepository;

        public ProductFeatureWriteManager(IProductFeatureWriteRepository productFeatureWriteRepository, IMapper mapper)
        {
            _productFeatureWriteRepository = productFeatureWriteRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<ProductFeatureAddDto>> Add(ProductFeatureAddDto request)
        {
            var result = _mapper.Map<ProductFeature>(request);
            if(result == null)
            {
                return ResponseDto<ProductFeatureAddDto>.Fail(Messages.AddFailMessage);
            }
            await _productFeatureWriteRepository.AddAsync(result);
            return ResponseDto<ProductFeatureAddDto>.Success(request);
        }

        public void DeleteById(int id)
        {
            _productFeatureWriteRepository.Remove(id);  
        }

        public void Update(ProductFeatureUpdateDto productFeatureUpdateDto)
        {
            var result = _mapper.Map<ProductFeature>(productFeatureUpdateDto);
            
            _productFeatureWriteRepository.Update(result);
          
        }
    }
}
