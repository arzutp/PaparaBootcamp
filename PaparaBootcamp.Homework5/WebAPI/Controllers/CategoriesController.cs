
using AutoMapper;
using BusinessLayer.Abstract.CategoryService;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.CategoryManager;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.CategoryRepository;
using DataAccessLayer.UnitOfWorks;
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
        private readonly IUnitOfWork _unitOfWork;
        public CategoriesController(IMapper mapper, ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository, IUnitOfWork unitOfWork)
        {
            _categoryReadService = new CategoryReadManager(mapper, categoryReadRepository);
            _categoryWriteService = new CategoryWriteManager(categoryWriteRepository, mapper);
            _unitOfWork = unitOfWork;
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
            await _unitOfWork.CommitAsync();
            return Created("", result);
        }

        [HttpPut]
        public IActionResult Update(CategoryUpdateDto categoryUpdateDto)
        {
            _categoryWriteService.Update(categoryUpdateDto);
            _unitOfWork.Commit();
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _categoryWriteService.DeleteById(id);
            _unitOfWork.Commit();
            return NoContent();
        }
    }
}
