using DataAccessLayer.Abstract.ProductRepository;
using DataAccessLayer.Contexts;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.ProductRepositories
{
    public class ProductReadRepository : BaseReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(PaparaHomeworkDbContext paparaHomeworkDbContext) : base(paparaHomeworkDbContext)
        {
        }
    }
}
