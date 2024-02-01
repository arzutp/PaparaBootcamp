using BusinessLayer.Response;
using EntityLayer.DTOs.CategoryDTOs;
using EntityLayer.DTOs.ProductDTOs;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.ProductServide
{
    public interface IProductReadService
    {
        List<ProductGetAllDto> GetAll();
        Task<ResponseDto<ProductGetByIdDto>> GetById(int id);
        List<ProductWithCategoryDto> GetAllProductsWithCategory();
        List<ProductWithDefinitionGetAllDto> GetAllProductWithDefinition();
    }
}
