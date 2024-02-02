using AutoMapper;
using BusinessLayer.Abstract.ProductDefinitionService;
using BusinessLayer.Abstract.ProductFeatureService;
using BusinessLayer.Concrete.ProductDefinitionManager;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.ProductDefinitionRepository;
using DataAccessLayer.UnitOfWorks;
using EntityLayer.DTOs.ProductDefinitionDTOs;
using EntityLayer.DTOs.ProductFeatureDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDefinitionsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductDefinitionReadService _productDefinitionReadService;
        private readonly IProductDefinitionWriteService _productDefinitionWriteService;

        public ProductDefinitionsController(IUnitOfWork unitOfWork, IMapper mapper, IProductDefinitionReadRepository productDefinitionReadRepository, IProductDefinitionWriteRepository productDefinitionWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _productDefinitionReadService = new ProductDefinitionReadManager(productDefinitionReadRepository,mapper);
            _productDefinitionWriteService = new ProductDefinitionWriteManager(productDefinitionWriteRepository,mapper);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productDefinitionReadService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var category = await _productDefinitionReadService.GetById(id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductDefinitionAddDto productDefinitionAddDto)
        {
            ResponseDto<ProductDefinitionAddDto> result = await _productDefinitionWriteService.Add(productDefinitionAddDto);
            await _unitOfWork.CommitAsync();
            return Created("", result);
        }

        [HttpPut]
        public IActionResult Update(ProductDefinitionUpdateDto productDefinitionUpdateDto)
        {
            _productDefinitionWriteService.Update(productDefinitionUpdateDto);
            _unitOfWork.Commit();
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _productDefinitionWriteService.DeleteById(id);
            _unitOfWork.Commit();
            return NoContent();
        }

    }
}
