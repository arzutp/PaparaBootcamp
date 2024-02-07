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
    public class CategoryWriteRepository : BaseWriteRepository<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(PaparaHomeworkDbContext context) : base(context)
        {
        }
    }
}
