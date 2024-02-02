
using PaparaHomework.Redis.Context;

namespace PaparaHomework.Redis.Models.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            var products = _context.Products.ToList();
            return products;
        }
    }
}
