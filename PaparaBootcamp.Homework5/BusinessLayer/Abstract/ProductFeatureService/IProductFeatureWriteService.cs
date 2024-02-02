using BusinessLayer.Response;
using EntityLayer.DTOs.ProductFeatureDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.ProductFeatureService
{
    public interface IProductFeatureWriteService
    {
        Task<ResponseDto<ProductFeatureAddDto>> Add(ProductFeatureAddDto request);
        void DeleteById(int id);
        void Update(ProductFeatureUpdateDto productFeatureUpdateDto);
    }
}
