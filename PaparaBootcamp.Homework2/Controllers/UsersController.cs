using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using PaparaBootcamp.Homework2.Models;
using PaparaBootcamp.Homework2.Models.Users.DTOs;
using PaparaBootcamp.Homework2.Models.Users.UserServices;

namespace PaparaBootcamp.Homework2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IFileProvider _fileProvider;

        public UsersController(IMapper mapper, IFileProvider fileProvider)
        {
            _userService = new UserService(mapper);
            _fileProvider = fileProvider;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }

        [Route("SaveFile")]
        [HttpPost]
        public IActionResult SavePictures(IFormFile formFile)
        {
            IDirectoryContents pictureDirectory = _fileProvider.GetDirectoryContents("wwwroot");
            IFileInfo pictures = pictureDirectory.Where(x=>x.Name == "Pictures")!.Single();

            var path = Path.Combine(pictures.PhysicalPath!, formFile.FileName);
            using FileStream stream = new FileStream(path, FileMode.Create);
            formFile.CopyTo(stream);

            return Created($"/pictures/{formFile.FileName}", null);
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

        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var result = _userService.GetByName(name);
            return Ok(result);
        }

        [HttpGet("age/{age}")]
        public IActionResult GetByAge(int age)
        {
            var result = _userService.GetByAge(age);
            return Ok(result);
        }
    }
}
