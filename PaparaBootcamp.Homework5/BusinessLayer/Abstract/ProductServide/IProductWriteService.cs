using BusinessLayer.Response;
using EntityLayer.DTOs.CategoryDTOs;
using EntityLayer.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.ProductServide
{
    public interface IProductWriteService
    {
        Task<ResponseDto<ProductAddDto>> Add(ProductAddDto request);
        void DeleteById(int id);
        void Update(ProductUpdateDto request);
    }
}
