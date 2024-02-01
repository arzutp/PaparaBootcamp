
using AutoMapper;
using BusinessLayer.Abstract.CategoryService;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.CategoryManager;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.CategoryRepository;
using EntityLayer.DTOs.CategoryDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryReadService _categoryReadService;
        private readonly ICategoryWriteService _categoryWriteService;
        public CategoriesController(IMapper mapper, ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryReadService = new CategoryReadManager(mapper, categoryReadRepository);
            _categoryWriteService = new CategoryWriteManager(categoryWriteRepository, mapper);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categoryReadService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var category = await _categoryReadService.GetById(id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            ResponseDto<CategoryAddDto> result = await _categoryWriteService.AddCategory(categoryAddDto);
            return Created("", result);
        }
    }
}
