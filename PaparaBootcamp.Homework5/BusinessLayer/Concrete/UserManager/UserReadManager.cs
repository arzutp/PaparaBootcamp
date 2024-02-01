using AutoMapper;
using BusinessLayer.Abstract.UserService;
using BusinessLayer.Constants;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.UserRepository;
using EntityLayer.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.UserManager
{
    public class UserReadManager : IUserReadService
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IMapper _mapper;

        public UserReadManager(IMapper mapper, IUserReadRepository userReadRepository)
        {
            _mapper = mapper;
            _userReadRepository = userReadRepository;
        }

        public List<UserGetAllDto> GetAll()
        {
            var users = _userReadRepository.GetAll();
            var userDto = _mapper.Map<List<UserGetAllDto>>(users);
            return userDto;
        }

        public async Task<ResponseDto<UserGetByIdDto>> GetById(int id)
        {
            var user = await _userReadRepository.GetByIdAsync(id);
            var result = _mapper.Map<UserGetByIdDto>(user);
            if(result ==  null)
            {
                return ResponseDto<UserGetByIdDto>.Fail(Messages.UserInvalid);
            }
            return ResponseDto<UserGetByIdDto>.Success(result);
        }
    }
}
