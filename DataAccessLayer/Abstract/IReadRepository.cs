using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        List<T> GetAll();
        Task<T> GetByIdAsync(int id);
    }
}
