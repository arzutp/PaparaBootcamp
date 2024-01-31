using EntityLayer.Entities;
using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.CategoryRepository
{
    public interface ICategoryReadRepository: IReadRepository<Category> 
    {
    }
}
