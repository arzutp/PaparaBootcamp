using DataAccessLayer.Abstract.CategoryRepository;
using DataAccessLayer.Contexts;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.CategoryRepositories
{
    public class CategoryReadRepository : BaseReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(PaparaHomeworkDbContext paparaHomeworkDbContext) : base(paparaHomeworkDbContext)
        {
        }
    }
}
