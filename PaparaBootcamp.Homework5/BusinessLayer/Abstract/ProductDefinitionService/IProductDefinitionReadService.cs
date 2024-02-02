using BusinessLayer.Response;
using EntityLayer.DTOs.CategoryDTOs;
using EntityLayer.DTOs.ProductDefinitionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.ProductDefinitionService
{
    public interface IProductDefinitionReadService
    {
        List<ProductDefinitionGetAllDto> GetAll();
        Task<ResponseDto<ProductDefinitionGetByIdDto>> GetById(int id);
    }
}
