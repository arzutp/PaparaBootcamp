
using AutoMapper;
using BusinessLayer.Abstract.CategoryService;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract.CategoryRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryReadService _categoryReadService;

        public CategoriesController(IMapper mapper, ICategoryReadRepository categoryReadRepository)
        {
            _categoryReadService = new CategoryReadManager(mapper, categoryReadRepository);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categoryReadService.GetAll());
        }
    }
}
