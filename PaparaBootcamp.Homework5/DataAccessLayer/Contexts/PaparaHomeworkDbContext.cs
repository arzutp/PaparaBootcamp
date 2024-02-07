using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class PaparaHomeworkDbContext : DbContext
    {
        public PaparaHomeworkDbContext(DbContextOptions<PaparaHomeworkDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDefinition> ProductDefinitions { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
