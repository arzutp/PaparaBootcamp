using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaparaBootcamp.Homework2.Models;
using PaparaBootcamp.Homework2.Models.Users.DTOs;
using PaparaBootcamp.Homework2.Models.Users.UserServices;

namespace PaparaBootcamp.Homework2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IMapper mapper)
        {
            _userService = new UserService(mapper);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }

        [HttpPost]
        public IActionResult Add(UserAddDtoRequest userAddDtoRequest) {
            ResponseDto<int> result = _userService.Add(userAddDtoRequest);
            return Created("", result);
        }

        [HttpPut]
        public IActionResult Update(UserUpdateDtoRequest userUpdateDtoRequest)
        {
            _userService.Update(userUpdateDtoRequest);
            return NoContent();
        }
        //update kısmına bir daha bak

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _userService.GetById(id);
            return Ok(result);
        }
    }
}
