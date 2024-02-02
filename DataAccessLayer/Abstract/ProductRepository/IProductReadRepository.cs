using EntityLayer.DTOs.ProductDTOs;
using EntityLayer.Entities;
using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.ProductRepository
{
    public interface IProductReadRepository : IReadRepository<Product> 
    {
        List<ProductWithCategoryDto> GetAllProductWithCategory();
        List<ProductWithDefinitionGetAllDto> GetAllProductWithDefinition(int id);
    }
}
