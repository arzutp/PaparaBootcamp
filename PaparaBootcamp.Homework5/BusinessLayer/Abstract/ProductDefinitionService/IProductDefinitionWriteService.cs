using BusinessLayer.Response;
using EntityLayer.DTOs.ProductDefinitionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.ProductDefinitionService
{
    public interface IProductDefinitionWriteService
    {
        Task<ResponseDto<ProductDefinitionAddDto>> Add(ProductDefinitionAddDto request);
        void DeleteById(int id);
        void Update(ProductDefinitionUpdateDto productDefinitionUpdateDto);
    }
}
