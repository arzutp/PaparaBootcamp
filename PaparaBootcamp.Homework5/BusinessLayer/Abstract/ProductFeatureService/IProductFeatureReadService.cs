using BusinessLayer.Response;
using EntityLayer.DTOs.ProductFeatureDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.ProductFeatureService
{
    public interface IProductFeatureReadService
    {
        List<ProductFeatureGetAllDto> GetAll();
        Task<ResponseDto<ProductFeatureGetByIdDto>> GetById(int id);
    }
}
