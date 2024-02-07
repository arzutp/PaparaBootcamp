using DataAccessLayer.Abstract;
using DataAccessLayer.Contexts;
using EntityLayer.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class BaseReadRepository<T> : IReadRepository<T> where T : BaseEntity, new()
    {
        private readonly PaparaHomeworkDbContext _context;

        public BaseReadRepository(PaparaHomeworkDbContext paparaHomeworkDbContext)
        {
            _context = paparaHomeworkDbContext;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking().ToList();  

        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
            return entity!;
        }
    }
}
