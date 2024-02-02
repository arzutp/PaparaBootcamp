using AutoMapper;
using BusinessLayer.Abstract.CategoryService;
using BusinessLayer.Abstract.ProductFeatureService;
using BusinessLayer.Concrete.ProductFeatureManager;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.ProductFeatureRepository;
using DataAccessLayer.UnitOfWorks;
using EntityLayer.DTOs.CategoryDTOs;
using EntityLayer.DTOs.ProductFeatureDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductFeaturesController : ControllerBase
    {
        private readonly IProductFeatureReadService _productFeatureReadService;
        private readonly IProductFeatureWriteService _productFeatureWriteService;
        private readonly IUnitOfWork _unitOfWork;

        public ProductFeaturesController(IUnitOfWork unitOfWork, IMapper mapper, IProductFeatureReadRepository productFeatureReadRepository, IProductFeatureWriteRepository productFeatureWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _productFeatureReadService = new ProductFeatureReadManager(productFeatureReadRepository,mapper);
            _productFeatureWriteService = new ProductFeatureWriteManager(productFeatureWriteRepository,mapper);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productFeatureReadService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var category = await _productFeatureReadService.GetById(id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductFeatureAddDto productFeatureAddDto)
        {
            ResponseDto<ProductFeatureAddDto> result = await _productFeatureWriteService.Add(productFeatureAddDto);
            await _unitOfWork.CommitAsync();
            return Created("", result);
        }

        [HttpPut]
        public IActionResult Update(ProductFeatureUpdateDto productFeatureUpdateDto)
        {
            _productFeatureWriteService.Update(productFeatureUpdateDto);
            _unitOfWork.Commit();
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _productFeatureWriteService.DeleteById(id);
            _unitOfWork.Commit();
            return NoContent();
        }
    }
}
