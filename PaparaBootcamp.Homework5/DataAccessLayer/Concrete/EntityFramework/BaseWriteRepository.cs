﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Contexts;
using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class BaseWriteRepository<T> : IWriteRepository<T> where T : BaseEntity, new()
    {
        private readonly PaparaHomeworkDbContext _context;

        public BaseWriteRepository(PaparaHomeworkDbContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            return entity;
        }

        public void Remove(int id)
        {
            var result = _context.Set<T>().FirstOrDefault(x => x.Id == id);
            _context.Remove(result!);      
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
