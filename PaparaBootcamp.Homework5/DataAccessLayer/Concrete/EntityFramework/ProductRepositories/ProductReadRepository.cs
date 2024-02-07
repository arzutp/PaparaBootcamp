using DataAccessLayer.Abstract.ProductRepository;
using DataAccessLayer.Contexts;
using EntityLayer.DTOs.ProductDTOs;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.ProductRepositories
{
    public class ProductReadRepository : BaseReadRepository<Product>, IProductReadRepository
    {
        private readonly PaparaHomeworkDbContext _context;
        public ProductReadRepository(PaparaHomeworkDbContext paparaHomeworkDbContext) : base(paparaHomeworkDbContext)
        {
            _context = paparaHomeworkDbContext;
        }

        public List<ProductWithCategoryDto> GetAllProductWithCategory()
        {
            // Eager Loading
            var products = _context.Products.Include(p => p.Category).Select(p => new ProductWithCategoryDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                CategoryId = p.CategoryId,
                CategoryName = p.Category.Name,
                CategoryDescription = p.Category.Description
            });
            return products.ToList();
        }

        public List<ProductWithDefinitionGetAllDto> GetAllProductWithDefinition(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {

                return new List<ProductWithDefinitionGetAllDto>();
            }
            _context.Entry(product!).Reference(p => p.ProductDefinition).Load();

            var result = new List<ProductWithDefinitionGetAllDto>
            {
                new ProductWithDefinitionGetAllDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    CategoryId = product.CategoryId,
                    StockCount = product.ProductDefinition?.StockCount ?? 0
                }
            };

            return result;
        }
    }
}
