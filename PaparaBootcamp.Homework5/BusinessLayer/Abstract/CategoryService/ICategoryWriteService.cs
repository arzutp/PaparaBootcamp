using BusinessLayer.Response;
using EntityLayer.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.CategoryService
{
    public interface ICategoryWriteService
    {
        Task<ResponseDto<CategoryAddDto>> AddCategory(CategoryAddDto request);
        void DeleteById(int id);
        void Update(CategoryUpdateDto categoryUpdateDto);
    }
}
