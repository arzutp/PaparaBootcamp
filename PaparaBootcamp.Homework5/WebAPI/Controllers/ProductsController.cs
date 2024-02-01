using AutoMapper;
using BusinessLayer.Abstract.CategoryService;
using BusinessLayer.Abstract.ProductServide;
using BusinessLayer.Concrete.ProductManager;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.ProductRepository;
using DataAccessLayer.UnitOfWorks;
using EntityLayer.DTOs.CategoryDTOs;
using EntityLayer.DTOs.ProductDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductReadService _productReadService;
        private readonly IProductWriteService _productWriteService;

        public ProductsController(IMapper mapper,IUnitOfWork unitOfWork, IProductReadRepository productReadRepository,IProductWriteRepository productWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _productReadService = new ProductReadManager(productReadRepository, mapper);
            _productWriteService = new ProductWriteManager(productWriteRepository,mapper);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productReadService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _productReadService.GetById(id);
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductAddDto productAddDto)
        {
            ResponseDto<ProductAddDto> result = await _productWriteService.Add(productAddDto);
            _unitOfWork.Commit();
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update(ProductUpdateDto productUpdateDto)
        {
            _productWriteService.Update(productUpdateDto);
            _unitOfWork.Commit();
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _productWriteService.DeleteById(id);
            _unitOfWork.Commit();
            return NoContent();
        }

        [HttpGet("WithCategory")]
        public IActionResult GetWithCategory()
        {
            var results = _productReadService.GetAllProductsWithCategory();
            return Ok(results);
        }

        [HttpGet("WithDefinition")]
        public IActionResult GetWithDefinition()
        {
            var results = _productReadService.GetAllProductWithDefinition();
            return Ok(results);
        }
    }
}
