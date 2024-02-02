using AutoMapper;
using BusinessLayer.Abstract.ProductDefinitionService;
using BusinessLayer.Constants;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.ProductDefinitionRepository;
using EntityLayer.DTOs.CategoryDTOs;
using EntityLayer.DTOs.ProductDefinitionDTOs;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ProductDefinitionManager
{
    public class ProductDefinitionWriteManager : IProductDefinitionWriteService
    {
        private readonly IMapper _mapper;
        private readonly IProductDefinitionWriteRepository _productDefinitionWriteRepository;

        public ProductDefinitionWriteManager(IProductDefinitionWriteRepository productDefinitionWriteRepository, IMapper mapper)
        {
            _productDefinitionWriteRepository = productDefinitionWriteRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<ProductDefinitionAddDto>> Add(ProductDefinitionAddDto request)
        {
            var productDefinitionDto = _mapper.Map<ProductDefinition>(request);
            if(productDefinitionDto == null)
            {
                return ResponseDto<ProductDefinitionAddDto>.Fail(Messages.AddFailMessage);
            }
            await _productDefinitionWriteRepository.AddAsync(productDefinitionDto);
            return ResponseDto<ProductDefinitionAddDto>.Success(request);
            
        }

        public void DeleteById(int id)
        {
            _productDefinitionWriteRepository.Remove(id);
        }

        public void Update(ProductDefinitionUpdateDto productDefinitionUpdateDto)
        {
            var productDefinition = _mapper.Map<ProductDefinition>(productDefinitionUpdateDto);
            _productDefinitionWriteRepository.Update(productDefinition);
        }
    }
}
