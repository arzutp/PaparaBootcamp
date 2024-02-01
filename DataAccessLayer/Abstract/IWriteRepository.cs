using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IWriteRepository<T> : IRepository<T> where T :  BaseEntity, new()
    {
        Task<T> AddAsync(T entity);
        void Remove(int id);
        void Update(T entity);
    }
}
