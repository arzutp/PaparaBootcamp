using DataAccessLayer.Contexts;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly PaparaHomeworkDbContext _context;

    public UnitOfWork(PaparaHomeworkDbContext context)
    {
        _context = context;
    }

    public IDbContextTransaction BeginTransaction()
    {
        return _context.Database.BeginTransaction();   
    }

    public int Commit()
    {
        return _context.SaveChanges();
    }

    public Task<int> CommitAsync()
    {
        return _context.SaveChangesAsync();
    }
}
