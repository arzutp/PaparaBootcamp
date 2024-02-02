using AutoMapper;
using BusinessLayer.Abstract.ProductDefinitionService;
using BusinessLayer.Constants;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.ProductDefinitionRepository;
using EntityLayer.DTOs.CategoryDTOs;
using EntityLayer.DTOs.ProductDefinitionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ProductDefinitionManager
{
    public class ProductDefinitionReadManager : IProductDefinitionReadService
    {
        private readonly IMapper _mapper;
        private readonly IProductDefinitionReadRepository _productDefinitionRead;

        public ProductDefinitionReadManager(IProductDefinitionReadRepository productDefinitionRead, IMapper mapper)
        {
            _productDefinitionRead= productDefinitionRead;
            _mapper = mapper;
        }

        public List<ProductDefinitionGetAllDto> GetAll()
        {
            var result = _productDefinitionRead.GetAll();
            var productDefinitionDto = _mapper.Map<List<ProductDefinitionGetAllDto>>(result);
            return productDefinitionDto;
        }

        public async Task<ResponseDto<ProductDefinitionGetByIdDto>> GetById(int id)
        {
            var productDefinition = await _productDefinitionRead.GetByIdAsync(id);
            var result = _mapper.Map<ProductDefinitionGetByIdDto>(productDefinition);
            if (result == null)
            {
                return ResponseDto<ProductDefinitionGetByIdDto>.Fail(Messages.CategoryInvalid);
            }
            return ResponseDto<ProductDefinitionGetByIdDto>.Success(result);
        }
    }
}
