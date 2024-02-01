using AutoMapper;
using BusinessLayer.Abstract.UserService;
using BusinessLayer.Constants;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.UserRepository;
using EntityLayer.DTOs.ProductDTOs;
using EntityLayer.DTOs.UserDTOs;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.UserManager
{
    public class UserWriteManager : IUserWriteService
    {
        private readonly IUserWriteRepository _userWriteRepository;
        private readonly IMapper _mapper;

        public UserWriteManager(IMapper mapper, IUserWriteRepository userWriteRepository)
        {
            _mapper = mapper;
            _userWriteRepository = userWriteRepository;
        }

        public async Task<ResponseDto<UserAddDto>> Add(UserAddDto request)
        {
            var user = _mapper.Map<User>(request);
            if(user == null)
            {
                return ResponseDto<UserAddDto>.Fail(Messages.AddFailMessage);
            }
            await _userWriteRepository.AddAsync(user);
            return ResponseDto<UserAddDto>.Success(request);
        }

        public void DeleteById(int id)
        {
            _userWriteRepository.Remove(id);
        }

        public void Update(UserUpdateDto request)
        {
            var user = _mapper.Map<User>(request);
            _userWriteRepository.Update(user);
        }
    }
}
