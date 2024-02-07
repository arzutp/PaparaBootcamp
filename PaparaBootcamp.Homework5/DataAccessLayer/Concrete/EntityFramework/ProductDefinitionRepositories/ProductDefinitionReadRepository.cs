using DataAccessLayer.Abstract.ProductDefinitionRepository;
using DataAccessLayer.Contexts;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.ProductDefinitionRepositories
{
    public class ProductDefinitionReadRepository : BaseReadRepository<ProductDefinition>, IProductDefinitionReadRepository
    {
        public ProductDefinitionReadRepository(PaparaHomeworkDbContext paparaHomeworkDbContext) : base(paparaHomeworkDbContext)
        {
        }
    }
}
