using AutoMapper;
using PaparaBootcamp.Homework2.Models.Users.DTOs;
using PaparaBootcamp.Homework2.Models.Users.Entity;
using PaparaBootcamp.Homework2.Models.Users.UserRepositories;

namespace PaparaBootcamp.Homework2.Models.Users.UserServices
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = new UserRepository();
        }
        public ResponseDto<int> Add(UserAddDtoRequest request)
        {
            int id = new Random().Next(1,100);
            User user = new User
            {
                Id = id,
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email!,
                Age = request.Age,
            };
            if (user == null)
            {
                return ResponseDto<int>.Fail("Hata var");
            }
            _userRepository.Add(user);

            return ResponseDto<int>.Success(id);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public List<UserDto> GetAll()
        {
            List<User> users = _userRepository.GetAll();

            List<UserDto> userDtos = _mapper.Map<List<UserDto>>(users);
            return userDtos;
        }

        public ResponseDto<List<UserGetByAgeDto>> GetByAge(int age)
        {
            var userGetByAge = _userRepository.GetByAge(age);
            List<UserGetByAgeDto> userGetByAgeDto = _mapper.Map<List<UserGetByAgeDto>>(userGetByAge);
            if(userGetByAgeDto.Count == 0)
            {
                return ResponseDto<List<UserGetByAgeDto>>.Fail("Böyle bir kullanıcı bulunamadı");
            }
            return ResponseDto<List<UserGetByAgeDto>>.Success(userGetByAgeDto);
        }

        public ResponseDto<UserGetByIdDto> GetById(int id)
        {
            var userGetById = _userRepository.GetById(id);
            UserGetByIdDto userGetByIdDto = _mapper.Map<UserGetByIdDto>(userGetById);
            if(userGetById == null)
            {
                return ResponseDto<UserGetByIdDto>.Fail("bu id de bir data yok");
            }
            return ResponseDto<UserGetByIdDto>.Success(userGetByIdDto);
        }

        public ResponseDto<List<UserGetByNameDto>> GetByName(string name)
        {
            var userGetByName = _userRepository.GetByName(name);    
            List<UserGetByNameDto> userGetByNameDto = _mapper.Map<List<UserGetByNameDto>>(userGetByName);

            if(userGetByNameDto.Count == 0)
            {
                return ResponseDto<List<UserGetByNameDto>>.Fail("Bu isimde bir kullanıcı yok");
            }
            return ResponseDto<List<UserGetByNameDto>>.Success(userGetByNameDto!);
        }

        public void Update(UserUpdateDtoRequest request)
        {
            User user = new User { Id = request.Id, 
                Name = request.Name, 
                Surname = request.Surname, 
                Age = request.Age, 
                Email = request.Email
            };
            _userRepository.Update(user);
        }
    }
}
