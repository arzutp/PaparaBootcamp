using PaparaBootcamp.Homework2.Models.Users.DTOs;
using PaparaBootcamp.Homework2.Models.Users.Entity;

namespace PaparaBootcamp.Homework2.Models.Users.UserServices
{
    public interface IUserService
    {
        List<UserDto> GetAll();
        void Delete(int id);
        ResponseDto<int> Add(UserAddDtoRequest request);
        void Update(UserUpdateDtoRequest request);
        ResponseDto<UserGetByIdDto> GetById(int id);
    }
}
