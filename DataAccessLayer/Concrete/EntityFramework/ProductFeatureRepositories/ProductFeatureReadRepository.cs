using DataAccessLayer.Abstract.ProductFeatureRepository;
using DataAccessLayer.Contexts;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.ProductFeatureRepositories
{
    public class ProductFeatureReadRepository : BaseReadRepository<ProductFeature>, IProductFeatureReadRepository
    {
        public ProductFeatureReadRepository(PaparaHomeworkDbContext paparaHomeworkDbContext) : base(paparaHomeworkDbContext)
        {
        }
    }
}
