using AutoMapper;
using BusinessLayer.Abstract.CategoryService;
using BusinessLayer.Abstract.UserService;
using BusinessLayer.Concrete.UserManager;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.UserRepository;
using DataAccessLayer.UnitOfWorks;
using EntityLayer.DTOs.CategoryDTOs;
using EntityLayer.DTOs.UserDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadService _userReadService;
        private readonly IUserWriteService _userWriteService;

        public UsersController(IMapper mapper,IUserWriteRepository userWriteRepository, IUserReadRepository userReadRepository, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _userWriteService = new UserWriteManager(mapper, userWriteRepository);
            _userReadService = new UserReadManager(mapper,userReadRepository);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userReadService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _userReadService.GetById(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            ResponseDto<UserAddDto> result = await _userWriteService.Add(userAddDto);
            await _unitOfWork.CommitAsync();
            return Created("", result);
        }

        [HttpPut]
        public IActionResult Update(UserUpdateDto userUpdateDto)
        {
            _userWriteService.Update(userUpdateDto);
            _unitOfWork.Commit();
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _userWriteService.DeleteById(id);
            _unitOfWork.Commit();
            return NoContent();
        }
    }
}
