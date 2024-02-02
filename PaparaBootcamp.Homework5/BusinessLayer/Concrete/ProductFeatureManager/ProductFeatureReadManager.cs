using AutoMapper;
using BusinessLayer.Abstract.ProductFeatureService;
using BusinessLayer.Constants;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.ProductFeatureRepository;
using EntityLayer.DTOs.CategoryDTOs;
using EntityLayer.DTOs.ProductFeatureDTOs;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ProductFeatureManager
{
    public class ProductFeatureReadManager : IProductFeatureReadService
    {
        private readonly IMapper _mapper;
        private readonly IProductFeatureReadRepository _productFeatureReadRepository;

        public ProductFeatureReadManager(IProductFeatureReadRepository productFeatureReadRepository, IMapper mapper)
        {
            _productFeatureReadRepository = productFeatureReadRepository;
            _mapper = mapper;
        }

        public List<ProductFeatureGetAllDto> GetAll()
        {
            var productFeatures = _productFeatureReadRepository.GetAll();
            var result = _mapper.Map<List<ProductFeatureGetAllDto>>(productFeatures);
            return result;
        }

        public async Task<ResponseDto<ProductFeatureGetByIdDto>> GetById(int id)
        {
            var productFeature = await _productFeatureReadRepository.GetByIdAsync(id);
            var result = _mapper.Map<ProductFeatureGetByIdDto>(productFeature);
            if(result == null)
            {
                return ResponseDto<ProductFeatureGetByIdDto>.Fail(Messages.FailIdMessage);
            }
            return ResponseDto<ProductFeatureGetByIdDto>.Success(result);
        }

       
    }
}
