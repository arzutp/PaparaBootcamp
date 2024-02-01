using BusinessLayer.Response;
using EntityLayer.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.CategoryService
{
    public interface ICategoryReadService
    {
        List<CategoryGetAllDto> GetAll();
        Task<ResponseDto<CategoryGetByIdDto>> GetById(int id);
    }
}
