using BusinessLayer.Response;
using EntityLayer.DTOs.ProductDTOs;
using EntityLayer.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.UserService
{
    public interface IUserWriteService
    {
        Task<ResponseDto<UserAddDto>> Add(UserAddDto request);
        void DeleteById(int id);
        void Update(UserUpdateDto request);
    }
}
